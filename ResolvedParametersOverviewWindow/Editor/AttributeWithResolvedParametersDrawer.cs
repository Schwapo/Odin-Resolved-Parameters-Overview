using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using System;
using System.Globalization;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public class AttributeWithResolvedParametersDrawer
        : OdinValueDrawer<AttributeWithResolvedParameters>
    {
        private const int Padding = 20;
        private const int ContainerContentPadding = 10;

        private static readonly DateTime LastUpdate = new DateTime(2022, 2, 1);

        private static readonly Color DarkLineColor = EditorGUIUtility.isProSkin
            ? SirenixGUIStyles.BorderColor
            : new Color(0f, 0f, 0f, 0.2f);

        private static readonly Color LightLineColor = EditorGUIUtility.isProSkin
            ? new Color(1f, 1f, 1f, 0.1f)
            : new Color(1f, 1f, 1f, 1f);

        private static readonly Color CodeTextColor = new Color(0.863f, 0.863f, 0.863f, 1f);

        private static readonly Color CodeBackgroundColor = EditorGUIUtility.isProSkin
            ? new Color(0.8f, 0.8f, 0.8f, 1f)
            : new Color(0.14f, 0.14f, 0.14f, 1f);

        private static readonly GUIContent WarnIcon = EditorGUIUtility.isProSkin
            ? EditorGUIUtility.IconContent("d_console.warnicon.inactive.sml@2x")
            : EditorGUIUtility.IconContent("console.warnicon.inactive.sml@2x");

        private static readonly GUIStyle CodeStyle = new GUIStyle("textarea")
        {
            richText = true,
            hover = { textColor = CodeTextColor },
            normal = { textColor = CodeTextColor },
            active = { textColor = CodeTextColor },
            focused = { textColor = CodeTextColor },
            padding = new RectOffset(Padding, Padding, Padding, Padding),
        };

        private static readonly GUIStyle HeaderStyle = new GUIStyle(SirenixGUIStyles.SectionHeaderCentered)
        {
            fontSize = 18,
        };

        private static readonly GUIStyle ContainerContentStyle = new GUIStyle(SirenixGUIStyles.ToolbarBackground)
        {
            stretchHeight = false,
            padding = new RectOffset(
                ContainerContentPadding,
                ContainerContentPadding,
                ContainerContentPadding,
                ContainerContentPadding),
        };

        protected override void Initialize()
        {
            var resolvedParameters = ValueEntry.SmartValue.ResolvedParameters;
            resolvedParameters.ForEach(p => p.Example.CollapsePreviews());

            ResolvedParametersOverviewWindow.OnWindowResized += () => resolvedParameters.ForEach(p => p.ResizeTables());

            // Odin's table needs to be drawn once for us to be able to get the right table cell width which is necessary
            // to calculate the content height. Delay resizing to give Odin the chance to draw it at least once.
            EditorApplication.delayCall += () =>
            {
                resolvedParameters.ForEach(p => p.ResizeTables());
                ResolvedParametersOverviewWindow.RepaintWindow();
            };
        }

        protected override void DrawPropertyLayout(GUIContent label)
        {
            var attribute = ValueEntry.SmartValue;

            var searchedParameters = attribute.ResolvedParameters
                .Where(p => ResolvedParametersOverviewWindow.SearchedFor(p.Name));

            SirenixEditorGUI.BeginVerticalList(false);

            foreach (var resolvedParameter in attribute.ResolvedParameters)
            {
                if (!searchedParameters.Any() || searchedParameters.Contains(resolvedParameter))
                {
                    DrawResolvedParameter(attribute, resolvedParameter);
                }
            }

            SirenixEditorGUI.EndVerticalList();

            DrawFooter(attribute);
        }

        private void DrawResolvedParameter(AttributeWithResolvedParameters attribute, ResolvedParameter resolvedParameter)
        {
            SirenixEditorGUI.BeginListItem(false);
            BeginPadding();

            GUILayout.Label(resolvedParameter.Name, HeaderStyle);
            GUILayout.Label(attribute.Name, SirenixGUIStyles.CenteredGreyMiniLabel);
            DrawSeperator();
            GUILayout.Label(resolvedParameter.Description, SirenixGUIStyles.MultiLineCenteredLabel);

            if (!resolvedParameter.AdditionalInfo.IsNullOrWhitespace())
            {
                var seperatorRect = EditorGUILayout.BeginHorizontal();
                DrawSeperator();
                var iconSize = 16f;
                GUILayout.Space((Padding * 2) + iconSize);
                GUI.DrawTexture(seperatorRect.AlignCenterX(iconSize).SetHeight(iconSize).AddY(13f), WarnIcon.image);
                DrawSeperator();
                EditorGUILayout.EndHorizontal();
                GUILayout.Label(resolvedParameter.AdditionalInfo, SirenixGUIStyles.MultiLineCenteredLabel);
            }

            DrawSeperator();
            resolvedParameter.ResolverInfoTable.DrawTable();
            DrawSeperator();
            resolvedParameter.NamedValueTable.DrawTable();
            DrawSeperator();
            DrawExample(resolvedParameter);

            EndPadding();
            GUILayout.FlexibleSpace();
            SirenixEditorGUI.EndListItem();
        }

        private void BeginPadding(float horizontalPadding = Padding, float verticalPadding = Padding)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(horizontalPadding);
            EditorGUILayout.BeginVertical();
            GUILayout.Space(verticalPadding);
        }

        private void EndPadding(float horizontalPadding = Padding, float verticalPadding = Padding)
        {
            GUILayout.Space(verticalPadding);
            EditorGUILayout.EndVertical();
            GUILayout.Space(horizontalPadding);
            EditorGUILayout.EndHorizontal();
        }

        private void DrawSeperator(float spaceBefore = Padding, float spaceAfter = Padding)
        {
            EditorGUILayout.BeginVertical();
            GUILayout.Space(spaceBefore);
            SirenixEditorGUI.HorizontalLineSeparator(DarkLineColor);
            SirenixEditorGUI.HorizontalLineSeparator(LightLineColor);
            GUILayout.Space(spaceAfter);
            EditorGUILayout.EndVertical();
        }

        private void DrawExample(ResolvedParameter resolvedParameter)
        {
            var headerRect = DrawContainer("Code", () =>
            {
                var defaultBackgroundColor = GUI.backgroundColor;
                GUI.backgroundColor = CodeBackgroundColor;
                EditorGUILayout.TextArea(resolvedParameter.Example.HighlightedCode, CodeStyle);
                GUI.backgroundColor = defaultBackgroundColor;
            });

            var buttonWidth = GetWidth("  Copy  ");
            var buttonRect = headerRect.AlignRight(buttonWidth);

            if (GUI.Button(buttonRect, "  Copy  ", SirenixGUIStyles.ToolbarButton))
            {
                Clipboard.Copy(resolvedParameter.Example.Code);
            }

            GUILayout.Space(Padding);

            DrawContainer("Preview", () => resolvedParameter.Example.DrawPreview());
        }

        private Rect DrawContainer(string title, Action drawContent)
        {
            var headerRect = SirenixEditorGUI.BeginHorizontalToolbar();
            var titleWidth = GetWidth(title);
            var titleRect = headerRect.AlignCenter(titleWidth);

            EditorGUI.LabelField(titleRect, title);
            GUILayout.FlexibleSpace();
            SirenixEditorGUI.EndHorizontalToolbar();

            GUILayout.Space(-1);

            var contentRect = EditorGUILayout.BeginVertical(ContainerContentStyle);
            drawContent();
            EditorGUILayout.EndVertical();

            SirenixEditorGUI.DrawBorders(contentRect, 1);

            return headerRect;
        }

        private float GetWidth(string content)
        {
            return GUI.skin.label.CalcSize(GUIHelper.TempContent(content)).x;
        }

        private void DrawFooter(AttributeWithResolvedParameters attribute)
        {
            BeginPadding();
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Attribute Documentation"))
            {
                Help.BrowseURL(attribute.DocumentationUrl);
            }

            if (GUILayout.Button("Attribute Examples"))
            {
                Help.BrowseURL(attribute.AttributeUrl);
            }

            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Resolvers Tutorial"))
            {
                Help.BrowseURL("https://odininspector.com/tutorials/value-and-action-resolvers/resolving-strings-to-stuff");
            }

            if (GUILayout.Button("Attribute Expressions Tutorial"))
            {
                Help.BrowseURL("https://odininspector.com/tutorials/using-attributes/attribute-expressions");
            }

            if (GUILayout.Button("Named Values Tutorial"))
            {
                Help.BrowseURL("https://odininspector.com/tutorials/value-and-action-resolvers/named-values");
            }

            EditorGUILayout.EndHorizontal();

            GUILayout.Space(Padding);

            EditorGUILayout.LabelField(
                $"Last update: {LastUpdate.ToString("d", DateTimeFormatInfo.InvariantInfo)}",
                SirenixGUIStyles.CenteredGreyMiniLabel);

            EndPadding();
        }
    }
}
