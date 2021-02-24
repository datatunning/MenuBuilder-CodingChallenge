using System.Collections.Generic;

namespace DerivCo.interfaces
{
    /// <summary>
    /// Interface for the MenuItem
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sub menu.
        /// </summary>
        /// <value>
        /// The sub menu.
        /// </value>
        public List<IMenuItem> SubMenu { get; set; }
    }
}
