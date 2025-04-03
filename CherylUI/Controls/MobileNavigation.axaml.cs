using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Avalonia.VisualTree;
using System;

namespace CherylUI.Controls;

 public partial class MobileNavigation : UserControl
    {
        public MobileNavigation()
        {
            InitializeComponent();
        }

     
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void PopPage()
        {    
            if (Pages.Count == 0)
                return;

            var page = Pages.Pop();

            Content = page;
            CurrentPage = page;
        }

        public static void Pop()
        {
            var instance = GetMobileStackInstance();
            
            if (instance.Pages.Count == 0)
                return;

            var page = instance.Pages.Pop();
           
            
            instance.CurrentPage = page;
            
            var x = instance.GetTemplateChildren();
            TransitioningContentControl baseCT = (TransitioningContentControl) x.First(f => f.Name == "base");
            
            baseCT.Content = page;

      
    }
        public Control CurrentPage;

        public static void Push(UserControl content,bool DisableComeBack = false)
        {
            
            var instance = GetMobileStackInstance();

            if(instance.CurrentPage == null)
                instance.CurrentPage =(Control)instance.Content  ;

            instance.Pages.Push(instance.CurrentPage);

            if (DisableComeBack)
                instance.Pages.Clear();

            var m =  content ;
            instance.CurrentPage = m;
            
            

            var x = instance.GetTemplateChildren();
          
            TransitioningContentControl baseCT = (TransitioningContentControl) x.First(f => f.Name == "base");

            baseCT.Content = content;
            

    }

      

        public Stack<Control> Pages = new Stack<Control>();
        
        public static MobileNavigation GetMobileStackInstance()
        {
            MobileNavigation container = null;
            try
            {
                container = ((ISingleViewApplicationLifetime)Application.Current.ApplicationLifetime).MainView.GetVisualDescendants().OfType<MobileNavigation>().First();
                
            }
            catch (Exception exc)
            {
            
                try
                {
                    var m = ((IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime).MainWindow;
                        container = m.GetVisualDescendants().OfType<MobileNavigation>().First();
                }
                catch (Exception exc2)
                {
                    Console.WriteLine(exc2.Message);
                    throw new Exception("You are trying to use a InteractiveContainer functionality without declaring one !");
                }
                
            }

            return container;
        }

    }