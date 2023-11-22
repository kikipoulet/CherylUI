<div id="header" align="center">
 <kbd>
<img src="https://zupimages.net/up/23/46/jjt8.jpeg" width="250" height="200"></img> 
  </kbd>
<br/>
Yes it is.
</div>
<br/>

# ✨ Cheryl UI

### Mobile UI Library for AvaloniaUI ! <img src="https://www.avaloniaui.net/img/logo/avalonia-white-purple.svg"></img>

[Install CherylUI](https://github.com/kikipoulet/CherylUI/wiki/1.-Installation) 

[Controls Documentation](https://github.com/kikipoulet/CherylUI/wiki/2.-Controls) 

<br/>
<details>
  <summary>1.0.1 New Additions</summary>
 <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/navigationtransition.gif"></img> 
  <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/sliverpagelong.gif"></img> 
 <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/bottomtabs.gif"></img> 
  <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/datepicker.gif"></img> 
  <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/dialog.gif"></img> 
  <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/toast.gif"></img> 
</details>


 

<br/>

https://github.com/kikipoulet/CherylUI/assets/19242427/84b27103-5e32-4fe4-b916-88537f1d6679

After some mobile experiments in the [SukiUI](https://github.com/kikipoulet/SukiUI) library and because of the recent mobile improvements of AvaloniaUI, I've decided to move the mobile controls to a new library for mobile only and develop a real library for mobile.
<br/><br/>Mobile platform need controls complete resizing, quicker animations to preserve performance, some design changes and obviously some Mobile specific controls (Pickers, ..) 
<br/><br/>The main inspiration for design will be HarmonyOS design guidelines, while keeping a connection with SukiUI design.

### ℹ️ High-Level controls

An important side of this library is to make the mobile UI development experience as easy as possible, without having to care too much about layout, etc .. 

For example this Settings layout with working pickers and actions.

 <img src="https://raw.githubusercontent.com/kikipoulet/CherylUI/master/CherylImages/SettingsDemo.png"></img> 

```
<controls:SliverPage Header="Settings">
        <StackPanel>
            <controls:GroupBox Header="View mode">
                <StackPanel>
                    <formFields:FormFieldSwitch Title="Dark Mode" IsChecked="{Binding DarkMode}" />

                    <cherylUi:HorizontalSeparator />

                    <formFields:FormFieldAction Command="{Binding LaunchToast}" Title="Eye Comfort" />

                    <cherylUi:HorizontalSeparator />

                    <formFields:FormFieldNumberPicker Value="10" />

                    <cherylUi:HorizontalSeparator />

                    <formFields:FormFieldPicker DialogSubTitle="Text style of your system apps." DialogTitle="Text Style"
                                                SelectedItem="{Binding SelectedTextStyle}" Items="{Binding TextItems" Title="Text Style" /> 
                </StackPanel>
            </controls:GroupBox>
         </StackPanel>
 </controls:SliverPage>
```

The goal for this library will be to provide these kind of "top-level" controls in addition of mobile theming.
