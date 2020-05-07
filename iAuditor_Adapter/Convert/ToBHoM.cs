/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.ComponentModel;
using BH.oM.Reflection.Attributes;
using BH.oM.Base;
using BH.Engine.Reflection;
using System.Collections;
using BH.Engine.Units;

namespace BH.Adapter.iAuditor
{
    public static partial class Convert
    {
        /***************************************************/
        /****           Public Methods                  ****/
        /***************************************************/

        //public static EnvironmentalProductDeclaration ToEnvironmentalProductDeclaration(this CustomObject obj)
        //{
        //    int result = 0;

        //    IEnumerable<string> standards = null;
        //    if (obj.PropertyValue("industry_standards") != null)
        //        standards = obj.PropertyValue("industry_standards") as IEnumerable<string>;

        //    string declaredUnit = obj.PropertyValue("declared_unit")?.ToString() ?? "";
        //    string epdUnit = GetUnitsFromString(declaredUnit);
        //    double epdUnitMult = ConvertToSI(1, epdUnit);

        //    string densityString = obj.PropertyValue("density")?.ToString() ?? "";
        //    double densityVal = GetValFromString(densityString);
        //    string densityUnits = GetUnitsFromString(densityString);
        //    double density = ConvertToSI(densityVal, densityUnits);
        //    string gwp = obj.PropertyValue("gwp")?.ToString() ?? "";
        //    double gwpVal = (gwp == "") ? double.NaN : System.Convert.ToDouble(gwp.Substring(0, gwp.IndexOf(" "))) * epdUnitMult;

        //    EnvironmentalProductDeclaration epd = new EnvironmentalProductDeclaration
        //    {
        //        QuantityType = QuantityType.Volume,
        //        Id = obj.PropertyValue("id")?.ToString() ?? "",
        //        Name = obj.PropertyValue("name")?.ToString() ?? "",
        //        Manufacturer = obj.PropertyValue("manufacturer.name")?.ToString() ?? "",
        //        Plant = obj.PropertyValue("plant.name")?.ToString() ?? "",
        //        PostalCode = int.TryParse(obj.PropertyValue("plant.postal_code")?.ToString() ?? "", out result) ? result : 0,
        //        Density = density,
        //        GlobalWarmingPotential = gwpVal,
        //        BiogenicEmbodiedCarbon = obj.PropertyValue("biogenic_embodied_carbon") != null ? System.Convert.ToDouble(obj.PropertyValue("biogenic_embodied_carbon_z")) * epdUnitMult : double.NaN,
        //        Description = obj.PropertyValue("description")?.ToString() ?? "",
        //        IndustryStandards = standards != null  ? standards.ToList() : new List<string>(),
        //    };
                                
        //    return epd;
        //}

        /***************************************************/

    }
}
