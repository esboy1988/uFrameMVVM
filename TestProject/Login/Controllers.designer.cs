// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Invert.MVVMTest {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class LoginScreenControllerBase : ScreenController {
        
        public override void Initialize(ViewModel viewModel) {
            this.InitializeLoginScreen(((LoginScreenViewModel)(viewModel)));
        }
        
        public virtual LoginScreenViewModel CreateLoginScreen() {
            return ((LoginScreenViewModel)(this.Create()));
        }
        
        public override ViewModel CreateEmpty() {
            return new LoginScreenViewModel(this);
        }
        
        public virtual void InitializeLoginScreen(LoginScreenViewModel viewModel) {
        }
        
        public virtual void Login(LoginScreenViewModel viewModel) {
        }
    }
}