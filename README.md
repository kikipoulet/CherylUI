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

### 1.2 Release : Glassmorphism added

- [GlassCard control available.](https://github.com/kikipoulet/CherylUI/wiki/2.-Controls#glass-card) 

<img src="https://github.com/kikipoulet/CherylUI/assets/19242427/2bc501b1-63ca-49af-a1a8-40bf3a35b874" width="500">

 

<br/>

### Controls Demo (1.1 Release)

https://github.com/kikipoulet/CherylUI/assets/19242427/6f2d42f8-6476-473f-8986-1b82750c0236


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
