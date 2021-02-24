using System.Collections.Generic;
using DerivCo.interfaces;

namespace DerivCo
{
    /// <summary>
    /// Implementation of the MenuItem
    /// </summary>
    /// <seealso cref="DerivCo.interfaces.IMenuItem" />
    public class MenuItem : IMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public MenuItem(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="subMenu">The sub menu.</param>
        public MenuItem(string name, params MenuItem[] subMenu): this(name)
        {
            this.SubMenu.AddRange(subMenu);
        }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public List<IMenuItem> SubMenu { get; set; } = new List<IMenuItem>();
    }
}