'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("nik_validator.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to https://www.facebook.com/poetralesana.
        '''</summary>
        Friend ReadOnly Property facebookpage() As String
            Get
                Return ResourceManager.GetString("facebookpage", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to NIK validator
        '''n00b Developer : PoetralesanA
        '''Facebook : Facebook.com/poetralesana
        '''Gitlab : gitlab.com/poetralesana
        '''
        '''Thanks for AndyHaruna, Petak 6 Squad
        '''Special thanks : Xertz (LogIn GDI+ Theme), Shin Ryu.
        '''</summary>
        Friend ReadOnly Property infoApp() As String
            Get
                Return ResourceManager.GetString("infoApp", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to https://www.youtube.com/channel/UCesKL9YMfIjKaf7JysGmAQQ/videos.
        '''</summary>
        Friend ReadOnly Property youtube() As String
            Get
                Return ResourceManager.GetString("youtube", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
