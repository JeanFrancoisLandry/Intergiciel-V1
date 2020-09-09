﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PrevostApp.Data.Models
{
    public partial class StageBesoinMateriel
    {
        public Guid Guid { get; set; }
        public int? Numero { get; set; }
        public int? Version { get; set; }
        public int? EnsembleProduction { get; set; }
        public int? CodeBesoinProduction { get; set; }
        public short Mnset { get; set; }
        public int Position { get; set; }
        public int IdCarre { get; set; }
        public int IdTrou { get; set; }
        public string IdElement { get; set; }
        public short TypeMateriel { get; set; }
        public short Complexe { get; set; }
        public string Reference { get; set; }
        public int ConfigurationCouleur { get; set; }
        public int ConfigurationCouleurMaterialBrut { get; set; }
        public string ReferenceBrut { get; set; }
        public double Qte { get; set; }
        public float Longueur { get; set; }
        public float Hauteur { get; set; }
        public float Volume { get; set; }
        public int CodeDeFournisseur { get; set; }
        public short CodeEntrepot { get; set; }
        public short AutoriserAcommander { get; set; }
        public double QteAcommander { get; set; }
        public double QteAescompter { get; set; }
        public double QteEscompter { get; set; }
        public double QteReservee { get; set; }
        public short EstCopie { get; set; }
        public int CopieDuNumero { get; set; }
        public int CopieDeVersion { get; set; }
        public int NiveauCible { get; set; }
        public short NonAssemble { get; set; }
        public int CodeTypeProduit { get; set; }
        public short TypeLongueurPerso { get; set; }
        public double DeltaQte { get; set; }
        public short ComposantCommander { get; set; }
        public double Poids { get; set; }
        public DateTime? DateDeCreation { get; set; }
        public DateTime? DateDeModif { get; set; }
    }
}