using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public static class AttributeWithResolvedParametersMap
    {
        public static Dictionary<Type, AttributeWithResolvedParameters> Map = new Dictionary<Type, AttributeWithResolvedParameters>
        {
            {
                typeof(AssetListAttribute),
                new AttributeWithResolvedParameters("Asset List", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(AssetListExamples_CustomFilterMethod),
                        "Custom Filter Method",
                        "Expects a member name or an attribute expression that returns true if the asset should be included in the asset list, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>
                        {
                            new NamedValue("$asset", "TElement", "The asset which should be filtered where TElement is of the type that the list holds"),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the list that has the attribute applied to it"),
                            new NamedValue("$value", "TList", "The List that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(BoxGroupAttribute),
                new AttributeWithResolvedParameters("Box Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(BoxGroupExamples_LabelText),
                        "Label Text",
                        "Expects a member name or an attribute expression that returns the desired label.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "Group Name",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ButtonAttribute),
                new AttributeWithResolvedParameters("Button", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ButtonExamples_Name),
                        "Name",
                        "Expects a member name or an attribute expression that returns the desired name.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the method that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ColorPaletteAttribute),
                new AttributeWithResolvedParameters("Color Palette", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ColorPaletteExamples_PaletteName),
                        "Palette Name",
                        "Expects a member name or an attribute expression that returns the desired color palette name.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the Color field that has the attribute applied to it"),
                            new NamedValue("$value", "UnityEngine.Color", "The Color field/property that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(CustomContextMenuAttribute),
                new AttributeWithResolvedParameters("Custom Context Menu", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(CustomContextMenuExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the action to take when the context menu item is clicked.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(CustomValueDrawerAttribute),
                new AttributeWithResolvedParameters("Custom Value Drawer", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(CustomValueDrawerExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the custom drawer action to take.",
                        "",
                        "Value Resolver",
                        "TElement",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$label", "UnityEngine.GUIContent", "The objects label"),
                            new NamedValue("$callNextDrawer", "System.Func<GUIContent, bool>", "Calling this function will draw the default inspector for this element"),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(DetailedInfoBoxAttribute),
                new AttributeWithResolvedParameters("Detailed Info Box", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(DetailedInfoBoxExamples_VisibleIf),
                        "Visible If",
                        "Expects a member name or an attribute expression that returns true if the detailed info box should be visible, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "True",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(DetailedInfoBoxExamples_Message),
                        "Message",
                        "Expects a member name or an attribute expression that returns the desired message.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(DetailedInfoBoxExamples_Details),
                        "Details",
                        "Expects a member name or an attribute expression that returns the hideable details of the message box.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(DisableIfAttribute),
                new AttributeWithResolvedParameters("Disable If", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(DisableIfExamples_Condition),
                        "Condition",
                        "Expects a member name or an attribute expression that returns true if the object should be disabled, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(EnableIfAttribute),
                new AttributeWithResolvedParameters("Enable If", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(EnableIfExamples_Condition),
                        "Condition",
                        "Expects a member name or an attribute expression that returns true if the object should be enabled, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(FilePathAttribute),
                new AttributeWithResolvedParameters("File Path", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(FilePathExamples_ParentFolder),
                        "Parent Folder",
                        "Expects a member name or an attribute expression that returns the desired parent folder.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(FilePathExamples_Extensions),
                        "Extensions",
                        "Expects a member name or an attribute expression that returns a string of comma separated file extensions that should be allowed (dots are optional).",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(FolderPathAttribute),
                new AttributeWithResolvedParameters("Folder Path", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(FolderPathExamples_ParentFolder),
                        "Parent Folder",
                        "Expects a member name or an attribute expression that returns the desired parent folder.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(FoldoutGroupAttribute),
                new AttributeWithResolvedParameters("Foldout Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(FoldoutGroupExamples_GroupName),
                        "Group Name",
                        "Expects a member name or an attribute expression that returns the desired group name.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(GUIColorAttribute),
                new AttributeWithResolvedParameters("GUI Color", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(GUIColorExamples_GetColor),
                        "Get Color",
                        "Expects a member name or an attribute expression that returns the desired gui color.",
                        "",
                        "Value Resolver",
                        "UnityEngine.Color",
                        "Attribute.Color",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(HideIfAttribute),
                new AttributeWithResolvedParameters("Hide If", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(HideIfExamples_Condition),
                        "Condition",
                        "Expects a member name or an attribute expression that returns true if the object should be hidden, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(HideIfGroupAttribute),
                new AttributeWithResolvedParameters("Hide If Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(HideIfGroupExamples_Condition),
                        "Condition",
                        "Expects a member name or an attribute expression that returns true if this group and groups that are nested inside of it should be hidden, otherwise false.",
                        "Note that in the vast majority of cases where you simply want to be able to control the visibility of a single group, it is better to use the VisibleIf parameter that all group attributes have.",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(HorizontalGroupAttribute),
                new AttributeWithResolvedParameters("Horizontal Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(HorizontalGroupExamples_Title),
                        "Title",
                        "Expects a member name or an attribute expression that returns the desired horizontal group title.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(InfoBoxAttribute),
                new AttributeWithResolvedParameters("Info Box", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(InfoBoxExamples_VisibleIf),
                        "Visible If",
                        "Expects a member name or an attribute expression that returns true if the info box should be visible, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "True",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(InfoBoxExamples_Message),
                        "Message",
                        "Expects a member name or an attribute expression that returns the desired message.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(InlineButtonAttribute),
                new AttributeWithResolvedParameters("Inline Button", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(InlineButtonExamples_Label),
                        "Label",
                        "Expects a member name or an attribute expression that returns the desired button label.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(InlineButtonExamples_ShowIf),
                        "Show If",
                        "Expects a member name or an attribute expression that returns true if the button should be visible, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "True",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(InlineButtonExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the action to take when the button is clicked.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(LabelTextAttribute),
                new AttributeWithResolvedParameters("Label Text", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(LabelTextExamples_Text),
                        "Text",
                        "Expects a member name or an attribute expression that returns the desired label.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ListDrawerSettingsAttribute),
                new AttributeWithResolvedParameters("List Drawer Settings", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_CustomAddFunction),
                        "Custom Add Function",
                        "Expects the name of a method or an attribute expression that defines the action to take when the add button of the list is clicked.",
                        "",
                        "Value Resolver",
                        "TElement",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_CustomRemoveElementFunction),
                        "Custom Remove Element Function",
                        "Expects the name of a method or an attribute expression that defines the action to take when the remove button of the list element is clicked.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$removeElement", "TElement", "The list element to be removed."),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_CustomRemoveIndexFunction),
                        "Custom Remove Index Function",
                        "Expects the name of a method or an attribute expression that defines the action to take when the remove button of the list element is clicked.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$index", "System.Int32", "The index of the list item to be removed."),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_ElementColor),
                        "Element Color",
                        "Expects a member name or an attribute expression that returns the desired element color.",
                        "",
                        "Value Resolver",
                        "UnityEngine.Color",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$index", "System.Int32", "The index of the list item being drawn."),
                            new NamedValue("$defaultColor", "UnityEngine.Color", "The default color of this list item (can be changed in Odin's preferences)."),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_OnBeginListElementGUI),
                        "On Begin List Element GUI",
                        "Expects the name of a method or an attribute expression that defines the action to take before drawing the list element.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$index", "System.Int32", "The index of the list item being drawn."),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_OnEndListElementGUI),
                        "On End List Element GUI",
                        "Expects the name of a method or an attribute expression that defines the action to take after drawing the list element.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$index", "System.Int32", "The index of the list item being drawn."),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ListDrawerSettingsExamples_OnTitleBarGUI),
                        "On Title Bar GUI",
                        "Expects the name of a method or an attribute expression that defines the action to take when the list's title bar is being drawn. This will be called after the default elements of the toolbar have been drawn, but before the toolbar is ended.",
                        "",
                        "Action Resolver",
                        "Resoled Action",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(MaxValueAttribute),
                new AttributeWithResolvedParameters("Max Value", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(MaxValueExamples_Expression),
                        "Expression",
                        "Expects a member name or an attribute expression that returns the desired max value.",
                        "",
                        "Value Resolver",
                        "System.Double",
                        "Attribute.MaxValue",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(MinMaxSliderAttribute),
                new AttributeWithResolvedParameters("Min Max Slider", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(MinMaxSliderExamples_MinMaxValueGetter),
                        "Min Max Value Getter",
                        "Expects a member name or an attribute expression that returns a UnityEngine.Vector2 which is used as the min/max bounds.",
                        "If this is non-null, it overrides the behaviour of the MinValue, MinValueGetter, MaxValue and MaxValueGetter parameters.",
                        "Value Resolver",
                        "UnityEngine.Vector2",
                        "Attribute.MinValue\nAttribute.MaxValue",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(MinMaxSliderExamples_MinValueGetter),
                        "Min Value Getter",
                        "Expects a member name or an attribute expression that returns the desired minimum value of the UnityEngine.Vector2.",
                        "This will be overriden if Min Max Value Getter is non-null.",
                        "Value Resolver",
                        "System.Double",
                        "Attribute.MinValue",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(MinMaxSliderExamples_MaxValueGetter),
                        "Max Value Getter",
                        "Expects a member name or an attribute expression that returns the desired maximum value of the UnityEngine.Vector2.",
                        "This will be overriden if Min Max Value Getter is non-null.",
                        "Value Resolver",
                        "System.Double",
                        "Attribute.MaxValue",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(MinValueAttribute),
                new AttributeWithResolvedParameters("Min Value", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(MinValueExamples_Expression),
                        "Expression",
                        "Expects a member name or an attribute expression that returns the desired max value.",
                        "",
                        "Value Resolver",
                        "System.Double",
                        "Attribute.MinValue",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(OnCollectionChangedAttribute),
                new AttributeWithResolvedParameters("On Collection Changed", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(OnCollectionChangedExamples_Before),
                        "Before",
                        "Expects the name of a method or an attribute expression that defines the action to take before a change occurs to the collection.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$info", "Sirenix.OdinInspector.Editor.CollectionChangeInfo", "Contains information about a change that is going to occur to a collection"),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(OnCollectionChangedExamples_After),
                        "After",
                        "Expects the name of a method or an attribute expression that defines the action to take after a change has occured to the collection.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$info", "Sirenix.OdinInspector.Editor.CollectionChangeInfo", "Contains information about a change that has occurred to a collection"),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(OnInspectorDisposeAttribute),
                new AttributeWithResolvedParameters("On Inspector Dispose", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(OnInspectorDisposeExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the action to take when the property's drawers are disposed in the inspector.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(OnInspectorGUIAttribute),
                new AttributeWithResolvedParameters("On Inspector GUI", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(OnInspectorGUIExamples_Prepend),
                        "Prepend",
                        "Expects the name of a method or an attribute expression that defines the action to take before the property is drawn.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(OnInspectorGUIExamples_Append),
                        "Append",
                        "Expects the name of a method or an attribute expression that defines the action to take after the property is drawn.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(OnInspectorInitAttribute),
                new AttributeWithResolvedParameters("On Inspector Init", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(OnInspectorInitExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the action to take when the property's drawers are initialized.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(OnStateUpdateAttribute),
                new AttributeWithResolvedParameters("On State Update", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(OnStateUpdateExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the action to take when the property's state should be updated.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(OnValueChangedAttribute),
                new AttributeWithResolvedParameters("On Value Changed", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(OnValueChangedExamples_Action),
                        "Action",
                        "Expects the name of a method or an attribute expression that defines the action to take when the value has changed.",
                        "",
                        "Action Resolver",
                        "Sirenix.OdinInspector.Editor.ActionResolvers.ResolvedAction",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ProgressBarAttribute),
                new AttributeWithResolvedParameters("Progress Bar", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ProgressBarExamples_MinGetter),
                        "Min Getter",
                        "Expects a member name or an attribute expression that returns the desired minimum value of the progress bar.",
                        "",
                        "Value Resolver",
                        "T",
                        "Attribute.Min",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ProgressBarExamples_MaxGetter),
                        "Max Getter",
                        "Expects a member name or an attribute expression that returns the desired maximum value of the progress bar.",
                        "",
                        "Value Resolver",
                        "T",
                        "Attribute.Max",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ProgressBarExamples_ColorGetter),
                        "Color Getter",
                        "Expects a member name or an attribute expression that returns the desired color value of the progress bar's foreground.",
                        "",
                        "Value Resolver",
                        "UnityEngine.Color",
                        "Attribute.Color",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ProgressBarExamples_BackgroundColorGetter),
                        "Background Color Getter",
                        "Expects a member name or an attribute expression that returns the desired color value of the progress bar's background.",
                        "",
                        "Value Resolver",
                        "UnityEngine.Color",
                        "ProgressBarConfig.Default.BackgroundColor",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ProgressBarExamples_CustomValueStringGetter),
                        "Custom Value String Getter",
                        "Expects a member name or an attribute expression that returns the desired label of the progress bar.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(PropertyRangeAttribute),
                new AttributeWithResolvedParameters("Property Range", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(PropertyRangeExamples_MinGetter),
                        "Min Getter",
                        "Expects a member name or an attribute expression that returns the desired minimum value.",
                        "",
                        "Value Resolver",
                        "T",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(PropertyRangeExamples_MaxGetter),
                        "Max Getter",
                        "Expects a member name or an attribute expression that returns the desired maximum value.",
                        "",
                        "Value Resolver",
                        "T",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(PropertyTooltipAttribute),
                new AttributeWithResolvedParameters("Property Tooltip", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(PropertyTooltipExamples_Tooltip),
                        "Tooltip",
                        "Expects a member name or an attribute expression that returns the desired tooltip.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(RequiredAttribute),
                new AttributeWithResolvedParameters("Required", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(RequiredExamples_ErrorMessage),
                        "Error Message",
                        "Expects a member name or an attribute expression that returns the desired error message.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ShowIfAttribute),
                new AttributeWithResolvedParameters("Show If", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ShowIfExamples_Condition),
                        "Condition",
                        "Expects a member name or an attribute expression that returns true if the object should be shown, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "True",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ShowIfGroupAttribute),
                new AttributeWithResolvedParameters("Show If Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ShowIfGroupExamples_Condition),
                        "Condition",
                        "Expects a member name or an attribute expression that returns true if this group and groups that are nested inside of it should be shown, otherwise false.",
                        "Note that in the vast majority of cases where you simply want to be able to control the visibility of a single group, it is better to use the VisibleIf parameter that all group attributes have.",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(SuffixLabelAttribute),
                new AttributeWithResolvedParameters("Suffix Label", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(SuffixLabelExamples_Label),
                        "Label",
                        "Expects a member name or an attribute expression that returns the desired suffix label.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(TableMatrixAttribute),
                new AttributeWithResolvedParameters("Table Matrix", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(TableMatrixExamples_DrawElementMethod),
                        "Draw Element Method",
                        "Expects the name of a method or an attribute expression that defines how to draw the current table matrix element.",
                        "",
                        "Value Resolver",
                        "TElement",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$rect", "UnityEngine.Rect", "The rect of the current table cell"),
                            new NamedValue("$element", "TElement", "The current table element to draw (same as $value)"),
                            new NamedValue("$array", "TArray", "The array that has the attribute applied to it"),
                            new NamedValue("$x", "System.Int32", "The x index of the current table cell"),
                            new NamedValue("$y", "System.Int32", "The y index of the current table cell"),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "TElement", "The current table element to draw (same as $element)"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(TableMatrixExamples_HorizontalTitle),
                        "Horizontal Title",
                        "Expects a member name or an attribute expression that returns the desired horizontal title.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(TableMatrixExamples_VerticalTitle),
                        "Vertical Title",
                        "Expects a member name or an attribute expression that returns the desired vertical title.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(TitleAttribute),
                new AttributeWithResolvedParameters("Title", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(TitleExamples_Title),
                        "Title",
                        "Expects a member name or an attribute expression that returns the desired title.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }),
                    new ResolvedParameter(
                        typeof(TitleExamples_Subtitle),
                        "Subtitle",
                        "Expects a member name or an attribute expression that returns the desired subtitle.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(TitleGroupAttribute),
                new AttributeWithResolvedParameters("Title Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(TitleGroupExamples_GroupName),
                        "Group Name",
                        "Expects a member name or an attribute expression that returns the desired group name.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }),
                    new ResolvedParameter(
                        typeof(TitleGroupExamples_Subtitle),
                        "Subtitle",
                        "Expects a member name or an attribute expression that returns the desired group subtitle.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ToggleGroupAttribute),
                new AttributeWithResolvedParameters("Toggle Group", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ToggleGroupExamples_ToggleGroupTitle),
                        "Toggle Group Title",
                        "Expects a member name or an attribute expression that returns the desired title.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(TypeFilterAttribute),
                new AttributeWithResolvedParameters("Type Filter", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(TypeFilterExamples_FilterGetter),
                        "Filter Getter",
                        "Expects a member name or an attribute expression that returns a value that is assignable to IList.",
                        "",
                        "Value Resolver",
                        "System.Object",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ValidateInputAttribute),
                new AttributeWithResolvedParameters("Validate Input", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ValidateInputExamples_DefaultMessage),
                        "Default Message",
                        "Expects a member name or an attribute expression that returns the desired default message.",
                        "Make sure to prefix all member names within the string with a $ sign unless it's within an attribute expression, otherwise Odin will not be able to distinguish them from a normal string.",
                        "Value Resolver",
                        "System.String",
                        "Attribute.DefaultMessage ?? \"Value is invalid for '\" + Property.NiceName + \"'\"",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                    new ResolvedParameter(
                        typeof(ValidateInputExamples_Condition),
                        "Condition",
                        "Expects the name of a method or an attribute expression that returns true if the input is valid, otherwise false.",
                        "",
                        "Value Resolver",
                        "System.Boolean",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$message", "System.String", "The message to be displayed inside the info box."),
                            new NamedValue("$messageType", "Sirenix.OdinInspector.InfoMessageType", "The InfoMessageType of the drawn info box."),
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
            {
                typeof(ValueDropdownAttribute),
                new AttributeWithResolvedParameters("Value Dropdown", new List<ResolvedParameter>
                {
                    new ResolvedParameter(
                        typeof(ValueDropdownExamples_ValuesGetter),
                        "Values Getter",
                        "Expects a member name or an attribute expression that returns a value that is assignable to IList.",
                        "",
                        "Value Resolver",
                        "System.Object",
                        "None",
                        new List<NamedValue>()
                        {
                            new NamedValue("$property", "Sirenix.OdinInspector.Editor.InspectorProperty", "The InspectorProperty representing the object that has the attribute applied to it"),
                            new NamedValue("$value", "T", "The object that has the attribute applied to it"),
                        }
                    ),
                })
            },
        };

        public static void Deconstruct(
            this KeyValuePair<Type, AttributeWithResolvedParameters> kvp,
            out Type type, out AttributeWithResolvedParameters attribute)
        {
            type = kvp.Key;
            attribute = kvp.Value;
        }
    }
}
