﻿#pragma checksum "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89B9270C59E4A3E7DC5FB950AF4EE98EC50DD0D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Maths.Frame;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Maths.Frame {
    
    
    /// <summary>
    /// AddProblem
    /// </summary>
    public partial class AddProblem : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TaskNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadImageButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image SelectedImage;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CorrectAnswerTextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveAndExitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Maths;component/frame/fordatebase/addproblem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TaskNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.UploadImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
            this.UploadImageButton.Click += new System.Windows.RoutedEventHandler(this.UploadImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SelectedImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.CorrectAnswerTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SaveAndExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\..\..\Frame\ForDateBase\AddProblem.xaml"
            this.SaveAndExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
