//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("CookTime.Views.Registration.SimpleLoginPage.xaml", "Views/Registration/SimpleLoginPage.xaml", typeof(global::CookTime.Views.Forms.SimpleLoginPage))]

namespace CookTime.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Registration\\SimpleLoginPage.xaml")]
    public partial class SimpleLoginPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::CookTime.Controls.BorderlessEntry EmailEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::CookTime.Controls.BorderlessEntry PasswordEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.Buttons.SfButton loginButtonMain;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.Buttons.SfButton signUpButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SimpleLoginPage));
            EmailEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::CookTime.Controls.BorderlessEntry>(this, "EmailEntry");
            PasswordEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::CookTime.Controls.BorderlessEntry>(this, "PasswordEntry");
            loginButtonMain = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.Buttons.SfButton>(this, "loginButtonMain");
            signUpButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.Buttons.SfButton>(this, "signUpButton");
        }
    }
}
