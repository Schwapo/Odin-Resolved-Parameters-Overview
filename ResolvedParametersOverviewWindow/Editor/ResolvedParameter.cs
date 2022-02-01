using Sirenix.Utilities.Editor;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public class ResolvedParameter
    {
        private static readonly GUIStyle TableCellTextStyle
            = new GUIStyle(SirenixGUIStyles.MultiLineLabel)
            {
                padding = new RectOffset(10, 10, 10, 10),
                clipping = TextClipping.Overflow,
                richText = true
            };

        public string Name;
        public string Description;
        public string AdditionalInfo;
        public string ResolverType;
        public string ResolvesTo;
        public string FallbackValue;
        public List<NamedValue> NamedValues;
        public ResolvedParameterExample Example;
        public GUITable ResolverInfoTable;
        public GUITable NamedValueTable;

        public ResolvedParameter(
            Type exampleType, string name, string description, string additionalInfo,
            string resolverType, string resolvesTo, string fallbackValue, List<NamedValue> namedValues)
        {
            Name = name;
            Description = description;
            AdditionalInfo = additionalInfo;
            ResolverType = resolverType;
            ResolvesTo = resolvesTo;
            FallbackValue = fallbackValue;
            NamedValues = namedValues;
            Example = new ResolvedParameterExample(exampleType);

            ResolverInfoTable = GUITable.Create(1, null,
                new GUITableColumn()
                {
                    ColumnTitle = "Resolver Type",
                    OnGUI = (rect, _) => DrawTableCell(rect, resolverType),
                },
                new GUITableColumn()
                {
                    ColumnTitle = "Resolves To",
                    OnGUI = (rect, _) => DrawTableCell(rect, resolvesTo),
                },
                new GUITableColumn()
                {
                    ColumnTitle = "Fallback Value",
                    OnGUI = (rect, _) => DrawTableCell(rect, fallbackValue),
                });

            NamedValueTable = GUITable.Create(NamedValues, "Named Values",
                new GUITableColumn()
                {
                    ColumnTitle = "Name",
                    OnGUI = (rect, i) => DrawTableCell(rect, NamedValues[i].Name),
                },
                new GUITableColumn()
                {
                    ColumnTitle = "Type",
                    OnGUI = (rect, i) => DrawTableCell(rect, NamedValues[i].Type),
                },
                new GUITableColumn()
                {
                    ColumnTitle = "Description",
                    OnGUI = (rect, i) => DrawTableCell(rect, NamedValues[i].Description),
                });
        }

        private void DrawTableCell(Rect rect, string text)
        {
            EditorGUI.LabelField(rect, text, TableCellTextStyle);
        }

        public void ResizeTables()
        {
            var resolverTypeHeight = CalculateHeight(ResolverType, ResolverInfoTable, 0, 1);
            var resolvesToHeight = CalculateHeight(ResolvesTo, ResolverInfoTable, 1, 1);
            var fallbackValueHeight = CalculateHeight(FallbackValue, ResolverInfoTable, 2, 1);
            var maxHeight = Mathf.Max(resolverTypeHeight, resolvesToHeight, fallbackValueHeight);
            ResolverInfoTable[0, 1].Height = maxHeight + 10f;

            for (int row = 2; row < NamedValueTable.RowCount; row++)
            {
                var namedValue = NamedValues[row - 2];
                var nameHeight = CalculateHeight(namedValue.Name, NamedValueTable, 0, row);
                var typeHeight = CalculateHeight(namedValue.Type, NamedValueTable, 1, row);
                var descriptionHeight = CalculateHeight(namedValue.Description, NamedValueTable, 2, row);
                maxHeight = Mathf.Max(nameHeight, typeHeight, descriptionHeight);

                for (int col = 0; col < NamedValueTable.ColumnCount; col++)
                {
                    NamedValueTable[col, row].Height = maxHeight + 10f;
                }
            }

            ResolverInfoTable.ReCalculateSizes();
            NamedValueTable.ReCalculateSizes();
        }

        private float CalculateHeight(string content, GUITable table, int col, int row)
        {
            return TableCellTextStyle.CalcHeight(
                GUIHelper.TempContent(content),
                table[col, row].Rect.width);
        }
    }
}