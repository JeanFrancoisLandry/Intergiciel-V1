﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PrevostApp.Data.Models
{
    public partial class StageMaterielBase
    {
        public Guid IdLigne { get; set; }
        public string ReferenceBase { get; set; }
        public string Description { get; set; }
        public string TypeCalcul { get; set; }
        public string Niveau1 { get; set; }
        public string Niveau2 { get; set; }
        public string Niveau3 { get; set; }
        public string Niveau4 { get; set; }
        public string Niveau5 { get; set; }
        public int? CodeFournisseur { get; set; }
        public short? NonIncluFeuilleTravail { get; set; }
        public short? NonOptimise { get; set; }
        public short NonIncluBesoinMateriel { get; set; }
        public short? PrixCommanderKg { get; set; }
        public string RemplacePour { get; set; }
        public short? IdGroupeBudget { get; set; }
        public short? IdGroupeProduction { get; set; }
        public string Auto { get; set; }
        public short CommandeAuto { get; set; }
        public string Production { get; set; }
        public short CommandeProduction { get; set; }
        public string Famille { get; set; }
        public string Classe { get; set; }
        public short? CommandeOptimisation { get; set; }
        public short? Evaluateur { get; set; }
        public short? EstMonterCadre { get; set; }
        public string Role { get; set; }
        public short? PosteTravail { get; set; }
        public short CommandeOptimal { get; set; }
        public short? MaterielAuPosteTravail { get; set; }
        public short CalculTarifDouane { get; set; }
        public double? Secteur { get; set; }
        public double? CouleurPeriInterieur { get; set; }
        public double? CouleurPeriExterieur { get; set; }
        public double? PointX { get; set; }
        public double? Pointy { get; set; }
        public short CoteMateriel { get; set; }
        public short CôteMateriel { get; set; }
        public short ColorControl { get; set; }
        public short? Demonte { get; set; }
        public short? DefautMonter { get; set; }
        public double QteEmballe { get; set; }
        public short TypeEmballeUnitaire { get; set; }
        public int Id { get; set; }
        public short? NonIncluRapportMateriel { get; set; }
        public int Active { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
    }
}