﻿#pragma checksum "C:\Repos\MSFTLogo\MSFTLogo\AnimatableQuadrant.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D9C1477DCB666BAF44A65530E6BD09FD763AFAAB78E860D6CCEF43DAA069D16"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSFTLogo
{
    partial class AnimatableQuadrant : global::Windows.UI.Xaml.Controls.UserControl
    {


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        private global::Microsoft.Toolkit.Uwp.UI.Animations.AnimationSet ZoomInAnimation; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        private global::Microsoft.Toolkit.Uwp.UI.Animations.AnimationSet ZoomOutAnimation; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid ImageHolder; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            global::System.Uri resourceLocator = new global::System.Uri("ms-appx:///AnimatableQuadrant.xaml");
            global::Windows.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

        partial void UnloadObject(global::Windows.UI.Xaml.DependencyObject unloadableObject);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        private interface IAnimatableQuadrant_Bindings
        {
            void Initialize();
            void Update();
            void StopTracking();
            void DisconnectUnloadedObject(int connectionId);
        }

        private interface IAnimatableQuadrant_BindingsScopeConnector
        {
            global::System.WeakReference Parent { get; set; }
            bool ContainsElement(int connectionId);
            void RegisterForElementConnection(int connectionId, global::Windows.UI.Xaml.Markup.IComponentConnector connector);
        }
#pragma warning disable 0169    //  Proactively suppress unused field warning in case Bindings is not used.
#pragma warning disable 0649
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        private IAnimatableQuadrant_Bindings Bindings;
#pragma warning restore 0649
#pragma warning restore 0169
    }
}

