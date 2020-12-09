using RecordsViewerClient.Models;
using RecordsViewerClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Service
{
    public class AxleService
    {
        public List<OnEachAxleModel> FillOnEachAxleGridWithDatas(List<TransportAxleWeightViewModel> transports, List<TrailerAxleWeightViewModel> trailers,
            bool isTransport, bool isTrailer, ViewMain viewMain)
        {

            List<OnEachAxleModel> temp = new List<OnEachAxleModel>();
            int num = 1;
            int trailerAxlesCounter = trailers.Count;
            bool overload = false;
            int k = 0;
            string consideredOverloadInTones = "";
            string consideredOverloadInPercent = "";

            Action actionFillTrailers = () =>
            {
                if (isTrailer)
                {
                    try
                    {
                        int axleCount = 0;
                        float axleWeight = 0;
                        foreach (var t in trailers)
                        {
                            axleCount = t.WeightOnAxle.Count;
                            axleWeight = float.Parse(t.WeightOnAxle[k]);
                            if (float.Parse(t.WeightOnAxle[k]) > t.LimitInTones)
                            {
                                overload = true;
                                consideredOverloadInTones = string.Format("{0:0.00}", (axleWeight - t.LimitInTones));
                                consideredOverloadInPercent = string.Format("{0:0.00}", ((axleWeight - t.LimitInTones) / t.LimitInTones) * 100);
                            }

                            temp.Add(new OnEachAxleModel()
                            {
                                Number = num++,
                                CarSuspension = t.CarSuspension,
                                AxleGroup = t.AxleGroup,
                                InterAxleDistance = t.InterAxleDistance,
                                GroupInTones = t.GroupInTones,
                                WeightOnAxle = t.WeightOnAxle[k],
                                LimitInTones = t.LimitInTones,
                                Weight = t.Weight,
                                WheelPitch = t.WheelPitch
                            });

                            overload = false;
                            consideredOverloadInTones = "";
                            consideredOverloadInPercent = "";
                            axleWeight = float.Parse(t.WeightOnAxle.LastOrDefault());
                            k++;
                        }
                                //if (((trailers.Count + transports.Count) < axleCount) & isTransport)
                                //    grd_OnEachAxle.Rows.Add(num++, "", "", "", string.Format("{0:0.00}", axleWeight), "",
                                //         "", "", " ", " ", "", "", "");
                            }

                    catch (Exception)
                    {
                        viewMain.ShowMessageWindow("Предупреждение", "Данная модель сохранена с отклонением от указаных характеристик. " +
       "Число осей занижено.", Enums.EnumMessage.Danger);
                    }
                }
                if (!isTrailer)
                {
                    if (trailers.Count > 0)
                    {
                        foreach (var t in trailers)
                        {
                            for (int i = k; i < t.WeightOnAxle.Count; i++)
                                temp.Add(new OnEachAxleModel()
                                {
                                    Number = num++,
                                    CarSuspension = t.CarSuspension,
                                    AxleGroup = t.AxleGroup,
                                    InterAxleDistance = t.InterAxleDistance,
                                    GroupInTones = t.GroupInTones,
                                    WeightOnAxle = t.WeightOnAxle[i],
                                    LimitInTones = t.LimitInTones,
                                    Weight = t.Weight,
                                    WheelPitch = t.WheelPitch
                                });
                        }
                    }
                }
            };

            if (isTransport)
            {
                try
                {
                    foreach (var t in transports)
                    {
                        float axleWeight = float.Parse(t.WeightOnAxle[k].Replace('.', ','));
                        if (axleWeight > t.LimitInTones)
                        {
                            overload = true;
                            consideredOverloadInTones = string.Format("{0:0.00}", (axleWeight - t.LimitInTones));
                            consideredOverloadInPercent = string.Format("{0:0.00}", ((axleWeight - t.LimitInTones) / t.LimitInTones) * 100);
                        }

                        temp.Add(new OnEachAxleModel()
                        {
                            Number = num++,
                            CarSuspension = t.CarSuspension,
                            AxleGroup = t.AxleGroup,
                            InterAxleDistance = t.InterAxleDistance,
                            GroupInTones = t.GroupInTones,
                            WeightOnAxle = t.WeightOnAxle[k],
                            LimitInTones = t.LimitInTones,
                            Weight = t.Weight,
                            WheelPitch = t.WheelPitch
                        });

                        k++;
                        overload = false;
                        consideredOverloadInTones = "";
                        consideredOverloadInPercent = "";
                    }
                }
                catch (Exception)
                {
                    viewMain.ShowMessageWindow("Предупреждение", "Данная модель сохранена с отклонением от указаных характеристик. " +
    "Число осей занижено.", Enums.EnumMessage.Danger);
                }
            }

            if (!isTransport)
            {
                if (transports.Count > 0)
                {
                    foreach (var t in transports)
                    {
                        int i;
                        for (i = 0; i < t.WeightOnAxle.Count - trailerAxlesCounter; i++)
                        {
                            temp.Add(new OnEachAxleModel()
                            {
                                Number = num++,
                                CarSuspension = t.CarSuspension,
                                AxleGroup = t.AxleGroup,
                                InterAxleDistance = t.InterAxleDistance,
                                GroupInTones = t.GroupInTones,
                                WeightOnAxle = t.WeightOnAxle[i],
                                LimitInTones = t.LimitInTones,
                                Weight = t.Weight,
                                WheelPitch = t.WheelPitch
                            });
                        }
                        k = i;
                    }
                }
                actionFillTrailers();
            }

            return temp;
        }

    }
}
