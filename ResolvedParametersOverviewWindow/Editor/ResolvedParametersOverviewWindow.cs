using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;
using System.Linq;
using System;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public class ResolvedParametersOverviewWindow : OdinMenuEditorWindow
    {
        public static Action OnWindowResized;

        private static readonly OdinMenuTreeDrawingConfig Config = new OdinMenuTreeDrawingConfig();

        private static ResolvedParametersOverviewWindow window;
        private static ResolvedParametersOverviewWindow Window
        {
            get
            {
                if (window == null)
                {
                    window = GetWindow<ResolvedParametersOverviewWindow>();
                }

                return window;
            }
        }

        private float previousWindowWidth;
        private float previousMenuTreeWidth;

        [MenuItem("Tools/Odin Inspector/Resolved Parameters Overview")]
        public static void Open()
        {
            window = GetWindow<ResolvedParametersOverviewWindow>("Resolved Parameters Overview");
        }

        protected override void Initialize()
        {
            WindowPadding = Vector4.zero;
        }

        protected override void OnGUI()
        {
            base.OnGUI();

            var currentWindowWidth = Window.position.width;
            var currentMenuTreeWidth = Window.MenuWidth;

            if (currentWindowWidth != previousWindowWidth ||
                currentMenuTreeWidth != previousMenuTreeWidth)
            {
                previousWindowWidth = currentWindowWidth;
                previousMenuTreeWidth = currentMenuTreeWidth;
                OnWindowResized?.Invoke();
            }
        }

        protected override OdinMenuTree BuildMenuTree()
        {
            var tree = new OdinMenuTree();
            tree.Config = Config;
            tree.Config.SearchTerm = "";
            tree.Config.DrawSearchToolbar = true;
            tree.Config.SearchFunction = (menuItem) =>
            {
                if (SearchedFor(menuItem.Name)) return true;

                var attribute = (AttributeWithResolvedParameters)menuItem.Value;

                return attribute.ResolvedParameters.Any(p => SearchedFor(p.Name));
            };

            foreach (var (_, attribute) in AttributeWithResolvedParametersMap.Map)
            {
                tree.AddObjectAtPath(attribute.Name, attribute);
            }

            return tree;
        }

        public static bool SearchedFor(string str)
        {
            var unifiedSearchStr = str.ToLower().Replace(" ", "");
            var unifiedSearchTerm = Config.SearchTerm.ToLower().Replace(" ", "");
            return unifiedSearchStr.Contains(unifiedSearchTerm);
        }

        public static void RepaintWindow() => Window.Repaint();
    }
}
