#pragma checksum "..\..\profile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DFBAAED1572FB9517AFD763FC3580D4401120242C2132E2D47B8F536E138FB6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using Банк;


namespace Банк {
    
    
    /// <summary>
    /// profile
    /// </summary>
    public partial class profile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lg;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pr;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ppr;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lg_Copy;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lg_Copy1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lg_Copy3;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lg_Copy4;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Банк;component/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\profile.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lg = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\profile.xaml"
            this.lg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lo);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pr = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\profile.xaml"
            this.pr.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.pa);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ppr = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\profile.xaml"
            this.ppr.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.pa);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lg_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lg_Copy1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lg_Copy3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lg_Copy4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            
            #line 56 "..\..\profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 63 "..\..\profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

