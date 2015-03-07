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
    
    
    public class TestElementControllerBase : GameController {
        
        private TestElementViewModel _TestElement;
        
        private GameController _GameController;
        
        private TestElementController _TestElementController;
        
        [InjectAttribute("TestElement")]
        public TestElementViewModel TestElement {
            get {
                return _TestElement;
            }
            set {
                _TestElement = value;
            }
        }
        
        [Inject()]
        public GameController GameController {
            get {
                return _GameController;
            }
            set {
                _GameController = value;
            }
        }
        
        [Inject()]
        public TestElementController TestElementController {
            get {
                return _TestElementController;
            }
            set {
                _TestElementController = value;
            }
        }
        
        public override void Initialize(ViewModel viewModel) {
            this.InitializeTestElement(((TestElementViewModel)(viewModel)));
        }
        
        public virtual TestElementViewModel CreateTestElement() {
            return ((TestElementViewModel)(this.Create()));
        }
        
        public override ViewModel CreateEmpty() {
            return new TestElementViewModel(this);
        }
        
        public virtual void InitializeTestElement(TestElementViewModel viewModel) {
        }
    }
}
