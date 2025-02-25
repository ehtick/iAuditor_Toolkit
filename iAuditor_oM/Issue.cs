/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */
 
using System.ComponentModel;
using System.Collections.Generic;
using BH.oM.Base;


namespace BH.oM.Adapters.iAuditor
{

    [Description("An issue belonging to an audit")]
    public class Issue : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("Issue number supplied to audit")]
        public virtual int IssueNumber { get; set; }

        [Description("Priority tag to better categorize your issue")]
        public virtual string Priority { get; set; } // this could be an enum of options
        
        [Description("Status description at time of observation")]
        public virtual string Status { get; set; }

        [Description("Provide a list of assignees for the issue")]
        public virtual string Assign { get; set; }

        [Description("Provide a description for the scope of the issue")]
        public virtual string Description { get; set; }

        [Description("Media associated with the issue")]
        public virtual List<string> Media { get; set; }

        [Description("List of people issue is distributed to")]
        public virtual List<string> Distribution { get; set; }

        [Description("List of comments made on the issue")]
        public virtual List<Comment> Comments { get; set; }

        /***************************************************/
    }
}



