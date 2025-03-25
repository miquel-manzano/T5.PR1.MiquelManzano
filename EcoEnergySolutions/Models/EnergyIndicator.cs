﻿namespace EcoEnergySolutions.Models
{
    public class EnergyIndicator
    {
        public string Data { get; set; }
        public double PBEE_Hidroelectr { get; set; }
        public double PBEE_Carbo { get; set; }
        public double PBEE_GasNat { get; set; }
        public double PBEE_Fuel_Oil { get; set; }
        public double PBEE_CiclComb { get; set; }
        public double PBEE_Nuclear { get; set; }
        public double CDEEBC_ProdBruta { get; set; }
        public double CDEEBC_ConsumAux { get; set; }
        public double CDEEBC_ProdNeta { get; set; }
        public double CDEEBC_ConsumBomb { get; set; }
        public double CDEEBC_ProdDisp { get; set; }
        public double CDEEBC_TotVendesXarxaCentral { get; set; }
        public double CDEEBC_SaldoIntercanviElectr { get; set; }
        public double CDEEBC_DemandaElectr { get; set; }
        public string CDEEBC_TotalEBCMercatRegulat { get; set; }
        public string CDEEBC_TotalEBCMercatLliure { get; set; }
        public string FEE_Industria { get; set; }
        public string FEE_Terciari { get; set; }
        public string FEE_Domestic { get; set; }
        public string FEE_Primari { get; set; }
        public string FEE_Energetic { get; set; }
        public string FEEI_ConsObrPub { get; set; }
        public string FEEI_SiderFoneria { get; set; }
        public string FEEI_Metalurgia { get; set; }
        public string FEEI_IndusVidre { get; set; }
        public string FEEI_CimentsCalGuix { get; set; }
        public string FEEI_AltresMatConstr { get; set; }
        public string FEEI_QuimPetroquim { get; set; }
        public string FEEI_ConstrMedTrans { get; set; }
        public string FEEI_RestaTransforMetal { get; set; }
        public string FEEI_AlimBegudaTabac { get; set; }
        public string FEEI_TextilConfecCuirCalçat { get; set; }
        public string FEEI_PastaPaperCartro { get; set; }
        public string FEEI_AltresIndus { get; set; }
        public double DGGN_PuntFrontEnagas { get; set; }
        public double DGGN_DistrAlimGNL { get; set; }
        public double DGGN_ConsumGNCentrTerm { get; set; }
        public double CCAC_GasolinaAuto { get; set; }
        public double CCAC_GasoilA { get; set; }
    }
}
