using PrzychodniaDLL;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace PrzychodniaWCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Ping();


        #region Lekarz
        [OperationContract]
        List<Lekarz> PobierzLekarzy();

        [OperationContract]
        Lekarz DodajLekarza(Lekarz lekarz);

        [OperationContract]
        bool UsunLekarza(long id);
        #endregion

        #region Pacjent
        [OperationContract]
        List<Pacjent> PobierzPacjentow();

        [OperationContract]
        Pacjent DodajPacjenta(Pacjent pacjent);

        [OperationContract]
        bool UsunPacjenta(long id);
        #endregion

        #region Choroba
        [OperationContract]
        List<Choroba> PobierzChoroby();

        [OperationContract]
        Choroba DodajChorobe(Choroba choroba);

        [OperationContract]
        bool UsunChorobe(long id);
        #endregion

        #region Lek
        [OperationContract]
        List<Lek> PobierzLeki();

        [OperationContract]
        Lek DodajLek(Lek lek);

        [OperationContract]
        bool UsunLek(long id);
        #endregion

        #region Grafik
        [OperationContract]
        List<Grafik> PobierzGrafik(DateTime dateTime);

        [OperationContract]
        Grafik DodajGrafik(Grafik grafik);

        [OperationContract]
        bool UsunGrafik(long id);

        // TODO postaw diagnoze
        #endregion
    }
}