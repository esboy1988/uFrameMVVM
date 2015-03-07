namespace Invert.uFrame.MVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class SceneManagerNode : SceneManagerNodeBase {
        public virtual IEnumerable<InstancesReference> ImportedItems
        {
            get { return Subsystem.AvailableInstances; }
        }

        public IEnumerable<ElementNode> IncludedElements
        {
            get
            {
                return Subsystem.ImportedSystemsWithThis.SelectMany(p => p.GetContainingNodesInProject(Project)).OfType<ElementNode>().Distinct();

            }
        }
        public SubsystemNode Subsystem
        {
            get
            {
                var subsystemSlot = SubsystemInputSlot.Item as Export;
                if (subsystemSlot == null) return null;
                var node = subsystemSlot.Node;

                return node as SubsystemNode;
            }
        }

        public override void Validate(List<ErrorInfo> errors)
        {
            base.Validate(errors);
            if (Subsystem == null)
            {
                errors.AddError("A subsystem is required for this scene manager.");
            }
            if (SceneTransitions.Any(p => !p.Outputs.Any()))
            {
                errors.AddError("All transitions must have an end-point.");
            }

        }
    }
    
    public partial interface ISceneManagerConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
