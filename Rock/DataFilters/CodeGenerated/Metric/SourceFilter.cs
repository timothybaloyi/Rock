
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace Rock.DataFilters.Metric
{
    /// <summary>
    /// Metric Source Filter
    /// </summary>
    [Description( "Filter Metrics on Source" )]
    [Export( typeof( DataFilterComponent ) )]
    [ExportMetadata( "ComponentName", "Metric Source Filter" )]
    public partial class SourceFilter : TextPropertyFilter
    {

        /// <summary>
        /// Gets the name of the filtered entity type.
        /// </summary>
        /// <value>
        /// The name of the filtered entity type.
        /// </value>
        public override string FilteredEntityTypeName
        {
            get { return "Rock.Model.Metric"; }
        }

        /// <summary>
        /// Gets the name of the column.
        /// </summary>
        /// <value>
        /// The name of the column.
        /// </value>
        public override string PropertyName
        {
            get { return "Source"; }
        }

    }
}
