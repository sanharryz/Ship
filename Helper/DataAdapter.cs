using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VesselLoader.Models;

namespace VesselLoader.Helper
{
    internal class DataAdapter
    {
        public void saveTankData(string jsonString)
        {
            try
            {
                if(!Directory.Exists("Data"))
                    { 
                        Directory.CreateDirectory("Data");
                    }
                File.WriteAllText(@"Data\TankData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveDamageCaseData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\DamageCaseData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<DamageCaseMasterModel> getDamageCaseData()
        {
            try
            {
                if (!File.Exists("Data\\DamageCaseData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<DamageCaseMasterModel>>(File.ReadAllText(@"Data\DamageCaseData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveShipGeometryData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\ShipGeometryData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveBendingData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\BendingData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveShearData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\ShearData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BendingShearValueModel> getBendingData()
        {
            try
            {
                if (!File.Exists("Data\\BendingData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BendingShearValueModel>>(File.ReadAllText(@"Data\BendingData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BendingShearValueModel> getShearData()
        {
            try
            {
                if (!File.Exists("Data\\ShearData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BendingShearValueModel>>(File.ReadAllText(@"Data\ShearData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveCrossCurveData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\CrossCurveData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BendingShearValueModel> getAllowedBendingMomentData()
        {
            try
            {
                if (!File.Exists("Data\\AllowedBendingMomentData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BendingShearValueModel>>(File.ReadAllText(@"Data\AllowedBendingMomentData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public CrossCurve getCrossCurveData()
        {
            try
            {
                if (!File.Exists("Data\\CrossCurveData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<CrossCurve>(File.ReadAllText(@"Data\CrossCurveData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public ShipGeom getShipGeometryData()
        {
            try
            {
                if (!File.Exists("Data\\ShipGeometryData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ShipGeom>(File.ReadAllText(@"Data\ShipGeometryData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveCrossCurveInputData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\CrossCurveInputData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public CrossCurveInputDataModel getCrossCurveInputData()
        {
            try
            {
                if (!File.Exists("Data\\CrossCurveInputData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<CrossCurveInputDataModel>(File.ReadAllText(@"Data\CrossCurveInputData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveSectionListData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\SectionListData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Section> getSectionListData()
        {
            try
            {
                if (!File.Exists("Data\\SectionListData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Section>>(File.ReadAllText(@"Data\SectionListData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        

        public void saveVesselInfo(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\VesselInfo.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public VesselInfo getVesselInfo()
        {
            try
            {
                if (!File.Exists("Data\\VesselInfo.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<VesselInfo>(File.ReadAllText(@"Data\VesselInfo.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public LiquidMasterData getMasterLiquidData()
        {
            try
            {
                if (!File.Exists("Data\\Master\\LiquidMaster.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<LiquidMasterData>(File.ReadAllText(@"Data\Master\LiquidMaster.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Tank> getTankData()
        {
            try
            {
                if (!File.Exists("Data\\TankData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tank>>(File.ReadAllText(@"Data\TankData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }
        public void saveTankMappingData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\TankMappingData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public TankMappingModel getTankMappingData()
        {
            try
            {
                if (!File.Exists("Data\\TankMappingData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<TankMappingModel>(File.ReadAllText(@"Data\TankMappingData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }

        public void saveFixedWeightData(string jsonString)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                File.WriteAllText(@"Data\FixedWeightData.txt", jsonString);
            }
            catch (Exception ex) { throw ex; }
        }

        public SolidFixedWeightModeList getFixedWeightData()
        {
            try
            {
                if (!File.Exists("Data\\FixedWeightData.txt"))
                {
                    return null;
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<SolidFixedWeightModeList>(File.ReadAllText(@"Data\FixedWeightData.txt"));
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
