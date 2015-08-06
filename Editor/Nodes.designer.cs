// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Invert.uFrame.MVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    
    
    public class ElementNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode, IInstancesConnectable, IElementConnectable {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Commands", SectionVisibility.Always, OrderIndex=3, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CommandsChildItem> Commands {
            get {
                return PersistedItems.OfType<CommandsChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Properties", SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Collections", SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface IElementConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class SimpleClassNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Properties", SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Collections", SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface ISimpleClassConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class ViewNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, IViewComponentConnectable {
        
        private SceneProperties _SceneProperties;
        
        private Element _Element;
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleBindings {
            get {
                return this.Repository.AllOf<IBindingsConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("Bindings", SectionVisibility.Always, false, false, typeof(IBindingsConnectable), false, OrderIndex=2, HasPredefinedOptions=true, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<BindingsReference> Bindings {
            get {
                return PersistedItems.OfType<BindingsReference>();
            }
        }
        
        [Invert.Core.GraphDesigner.InputSlot("Scene Properties", false, SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual SceneProperties ScenePropertiesInputSlot {
            get {
                if (_SceneProperties == null) {
                    _SceneProperties = new SceneProperties() { Repository = Repository, Node = this };
                }
                return _SceneProperties;
            }
            set {
                _SceneProperties = value;
            }
        }
        
        [Invert.Core.GraphDesigner.InputSlot("Element", false, SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual Element ElementInputSlot {
            get {
                if (_Element == null) {
                    _Element = new Element() { Repository = Repository, Node = this };
                }
                return _Element;
            }
            set {
                _Element = value;
            }
        }
    }
    
    public partial interface IViewConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class ComputedPropertyNodeBase : Invert.Core.GraphDesigner.GenericNode, ITransitionsConnectable, IComputedPropertyConnectable {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleSubProperties {
            get {
                return this.Repository.AllOf<ISubPropertiesConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("Sub Properties", SectionVisibility.Always, false, false, typeof(ISubPropertiesConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<SubPropertiesReference> SubProperties {
            get {
                return PersistedItems.OfType<SubPropertiesReference>();
            }
        }
    }
    
    public partial interface IComputedPropertyConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class SubsystemNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleInstances {
            get {
                return this.Repository.AllOf<IInstancesConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("Instances", SectionVisibility.Always, true, false, typeof(IInstancesConnectable), true, OrderIndex=1, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<InstancesReference> Instances {
            get {
                return PersistedItems.OfType<InstancesReference>();
            }
        }
    }
    
    public partial interface ISubsystemConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class SceneTypeNodeBase : Invert.Core.GraphDesigner.GenericNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface ISceneTypeConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class MVVMNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IMVVMConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class StateMachineNodeBase : Invert.Core.GraphDesigner.GenericNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        private StartState _StartState;
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Transitions", SectionVisibility.Always, OrderIndex=1, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<TransitionsChildItem> Transitions {
            get {
                return Repository.AllOf<TransitionsChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.OutputSlot("Start State", false, SectionVisibility.WhenNodeIsFilter, OrderIndex=0, IsNewRow=true)]
        public virtual StartState StartStateOutputSlot {
            get {
                if (_StartState == null) {
                    _StartState = new StartState() { Repository = Repository, Node = this };
                }
                return _StartState;
            }
            set {
                _StartState = value;
            }
        }
    }
    
    public partial interface IStateMachineConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class StateNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleStateTransitions {
            get {
                return this.Repository.AllOf<IStateTransitionsConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("State Transitions", SectionVisibility.Always, false, false, typeof(IStateTransitionsConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<StateTransitionsReference> StateTransitions {
            get {
                return PersistedItems.OfType<StateTransitionsReference>();
            }
        }
    }
    
    public partial interface IStateConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class ViewComponentNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IViewComponentConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class CommandNodeBase : Invert.Core.GraphDesigner.GenericInheritableNode, Invert.Core.GraphDesigner.IClassTypeNode {
        
        public virtual string ClassName {
            get {
                return this.Name;
            }
        }
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Properties", SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<PropertiesChildItem> Properties {
            get {
                return PersistedItems.OfType<PropertiesChildItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.Section("Collections", SectionVisibility.Always, OrderIndex=0, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<CollectionsChildItem> Collections {
            get {
                return PersistedItems.OfType<CollectionsChildItem>();
            }
        }
    }
    
    public partial interface ICommandConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
    
    public class ServiceNodeBase : Invert.Core.GraphDesigner.GenericNode {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
        
        public virtual System.Collections.Generic.IEnumerable<Invert.Core.IItem> PossibleHandlers {
            get {
                return this.Repository.AllOf<IHandlersConnectable>().Cast<IItem>();
            }
        }
        
        [Invert.Core.GraphDesigner.ReferenceSection("Handlers", SectionVisibility.Always, false, false, typeof(IHandlersConnectable), false, OrderIndex=0, HasPredefinedOptions=false, IsNewRow=true)]
        public virtual System.Collections.Generic.IEnumerable<HandlersReference> Handlers {
            get {
                return Repository.AllOf<HandlersReference>();
            }
        }
    }
    
    public partial interface IServiceConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
