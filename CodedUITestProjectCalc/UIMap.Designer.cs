﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProjectCalc
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// HavingAddTest
        /// </summary>
        public void HavingAddTest()
        {
            #region Variable Declarations
            WinButton uIItem1Button = this.UIКалькуляторWindow.UIItemWindow.UIItem1Button;
            WinButton uIСложениеButton = this.UIКалькуляторWindow.UIItemWindow1.UIСложениеButton;
            WinButton uIItem2Button = this.UIКалькуляторWindow.UIItemWindow2.UIItem2Button;
            WinButton uIРавноButton = this.UIКалькуляторWindow.UIItemWindow3.UIРавноButton;
            #endregion

            // Click '1' button
            Mouse.Click(uIItem1Button, new Point(23, 16));

            // Click 'Сложение' button
            Mouse.Click(uIСложениеButton, new Point(21, 20));

            // Click '2' button
            Mouse.Click(uIItem2Button, new Point(24, 19));

            // Click 'Равно' button
            Mouse.Click(uIРавноButton, new Point(20, 43));
        }
        
        #region Properties
        public UIКалькуляторWindow UIКалькуляторWindow
        {
            get
            {
                if ((this.mUIКалькуляторWindow == null))
                {
                    this.mUIКалькуляторWindow = new UIКалькуляторWindow();
                }
                return this.mUIКалькуляторWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIКалькуляторWindow mUIКалькуляторWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIКалькуляторWindow : WinWindow
    {
        
        public UIКалькуляторWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Калькулятор";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";
            this.WindowTitles.Add("Калькулятор");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "131";
            this.WindowTitles.Add("Калькулятор");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem1Button
        {
            get
            {
                if ((this.mUIItem1Button == null))
                {
                    this.mUIItem1Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem1Button.SearchProperties[WinButton.PropertyNames.Name] = "1";
                    this.mUIItem1Button.WindowTitles.Add("Калькулятор");
                    #endregion
                }
                return this.mUIItem1Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem1Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "93";
            this.WindowTitles.Add("Калькулятор");
            #endregion
        }
        
        #region Properties
        public WinButton UIСложениеButton
        {
            get
            {
                if ((this.mUIСложениеButton == null))
                {
                    this.mUIСложениеButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIСложениеButton.SearchProperties[WinButton.PropertyNames.Name] = "Сложение";
                    this.mUIСложениеButton.WindowTitles.Add("Калькулятор");
                    #endregion
                }
                return this.mUIСложениеButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIСложениеButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "132";
            this.WindowTitles.Add("Калькулятор");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem2Button
        {
            get
            {
                if ((this.mUIItem2Button == null))
                {
                    this.mUIItem2Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = "2";
                    this.mUIItem2Button.WindowTitles.Add("Калькулятор");
                    #endregion
                }
                return this.mUIItem2Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem2Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "121";
            this.WindowTitles.Add("Калькулятор");
            #endregion
        }
        
        #region Properties
        public WinButton UIРавноButton
        {
            get
            {
                if ((this.mUIРавноButton == null))
                {
                    this.mUIРавноButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIРавноButton.SearchProperties[WinButton.PropertyNames.Name] = "Равно";
                    this.mUIРавноButton.WindowTitles.Add("Калькулятор");
                    #endregion
                }
                return this.mUIРавноButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIРавноButton;
        #endregion
    }
}
