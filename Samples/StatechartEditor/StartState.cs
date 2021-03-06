//Copyright � 2014 Sony Computer Entertainment America LLC. See License.txt.

using Sce.Atf.Controls.Adaptable.Graphs;

namespace StatechartEditorSample
{
    /// <summary>
    /// DomNode adapter for start pseudo-state</summary>
    public class StartState : StateBase
    {
        /// <summary>
        /// Gets the state type</summary>
        public override StateType Type
        {
            get { return StateType.Start; }
        }
    }
}
