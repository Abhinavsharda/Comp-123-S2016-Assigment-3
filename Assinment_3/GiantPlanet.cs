﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Abhinav Sharda
 * StudentNumber: 300868625
 * Description: The Driver class for Planet classes and Interfaces
 * DateCreated: July 7rd, 2016
 */
namespace Assinment_3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {

        // PRIVATE INSTANCE VARIABLES ********************************************

        private string _type;

        // PUBLIC PROPERTIES ***********************************************88

        /**<summary>
        * This is a property for our _type field.
        * </summary>
        *
        * @property Type
        */
        public string Type
        {
            get
            {
                return this._type;
            }

            set
            {
                this._type = value;
            }
        }

        // CONSTRUCTORS ************************************************************

        /** <summary>
        * This constructor method get the parameters of the Planets base class as well as type
        * as a local variable
        * </summary>
        *
        * @constructor GiantPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} type
        */
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        // PUBLIC METHODS ****************************************************

        /** <summary>
         * This public method HasMoon() returns true if the MoonCount is greater than zero
         * </summary>
         *
         * @method HasMoon
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** <summary>
         * This public method HasRings() returns true if the RingCount is greater than zero
         * </summary>
         *
         * @method RingCount
         * @returns {bool}
         */
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

