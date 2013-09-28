// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSchema.tt
using System;
using WPAppStudio.Entities.Base;

namespace WPAppStudio.Entities
{
    /// <summary>
    /// Implementation of the monumentsCollectionSchema Data Schema.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class monumentsCollectionSchema : BindableBase
    {
	    /// <summary>
        /// Identifier for instances created according monumentsCollectionSchema Data Schema.
        /// </summary>
		public Guid Id { get; set; }

        private string _title;

        /// <summary>
        /// Gets/Sets value of Title column.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _subtitle;

        /// <summary>
        /// Gets/Sets value of Subtitle column.
        /// </summary>
        public string Subtitle
        {
            get { return _subtitle; }
            set
            {
                SetProperty(ref _subtitle, value);
            }
        }

        private string _image;

        /// <summary>
        /// Gets/Sets value of Image column.
        /// </summary>
        public string Image
        {
            get { return _image; }
            set
            {
                SetProperty(ref _image, value);
            }
        }

        private string _description;

        /// <summary>
        /// Gets/Sets value of Description column.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                SetProperty(ref _description, value);
            }
        }
    }
}
