﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Przychodnia.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzLekarzy", ReplyAction="http://tempuri.org/IService1/PobierzLekarzyResponse")]
        PrzychodniaDLL.Lekarz[] PobierzLekarzy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzLekarzy", ReplyAction="http://tempuri.org/IService1/PobierzLekarzyResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Lekarz[]> PobierzLekarzyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajLekarza", ReplyAction="http://tempuri.org/IService1/DodajLekarzaResponse")]
        PrzychodniaDLL.Lekarz DodajLekarza(PrzychodniaDLL.Lekarz lekarz);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajLekarza", ReplyAction="http://tempuri.org/IService1/DodajLekarzaResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Lekarz> DodajLekarzaAsync(PrzychodniaDLL.Lekarz lekarz);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunLekarza", ReplyAction="http://tempuri.org/IService1/UsunLekarzaResponse")]
        bool UsunLekarza(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunLekarza", ReplyAction="http://tempuri.org/IService1/UsunLekarzaResponse")]
        System.Threading.Tasks.Task<bool> UsunLekarzaAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzPacjentow", ReplyAction="http://tempuri.org/IService1/PobierzPacjentowResponse")]
        PrzychodniaDLL.Pacjent[] PobierzPacjentow();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzPacjentow", ReplyAction="http://tempuri.org/IService1/PobierzPacjentowResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Pacjent[]> PobierzPacjentowAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajPacjenta", ReplyAction="http://tempuri.org/IService1/DodajPacjentaResponse")]
        PrzychodniaDLL.Pacjent DodajPacjenta(PrzychodniaDLL.Pacjent pacjent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajPacjenta", ReplyAction="http://tempuri.org/IService1/DodajPacjentaResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Pacjent> DodajPacjentaAsync(PrzychodniaDLL.Pacjent pacjent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunPacjenta", ReplyAction="http://tempuri.org/IService1/UsunPacjentaResponse")]
        bool UsunPacjenta(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunPacjenta", ReplyAction="http://tempuri.org/IService1/UsunPacjentaResponse")]
        System.Threading.Tasks.Task<bool> UsunPacjentaAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzChoroby", ReplyAction="http://tempuri.org/IService1/PobierzChorobyResponse")]
        PrzychodniaDLL.Choroba[] PobierzChoroby();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzChoroby", ReplyAction="http://tempuri.org/IService1/PobierzChorobyResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Choroba[]> PobierzChorobyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajChorobe", ReplyAction="http://tempuri.org/IService1/DodajChorobeResponse")]
        PrzychodniaDLL.Choroba DodajChorobe(PrzychodniaDLL.Choroba choroba);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajChorobe", ReplyAction="http://tempuri.org/IService1/DodajChorobeResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Choroba> DodajChorobeAsync(PrzychodniaDLL.Choroba choroba);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunChorobe", ReplyAction="http://tempuri.org/IService1/UsunChorobeResponse")]
        bool UsunChorobe(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunChorobe", ReplyAction="http://tempuri.org/IService1/UsunChorobeResponse")]
        System.Threading.Tasks.Task<bool> UsunChorobeAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzLeki", ReplyAction="http://tempuri.org/IService1/PobierzLekiResponse")]
        PrzychodniaDLL.Lek[] PobierzLeki();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzLeki", ReplyAction="http://tempuri.org/IService1/PobierzLekiResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Lek[]> PobierzLekiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajLek", ReplyAction="http://tempuri.org/IService1/DodajLekResponse")]
        PrzychodniaDLL.Lek DodajLek(PrzychodniaDLL.Lek lek);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajLek", ReplyAction="http://tempuri.org/IService1/DodajLekResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Lek> DodajLekAsync(PrzychodniaDLL.Lek lek);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunLek", ReplyAction="http://tempuri.org/IService1/UsunLekResponse")]
        bool UsunLek(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunLek", ReplyAction="http://tempuri.org/IService1/UsunLekResponse")]
        System.Threading.Tasks.Task<bool> UsunLekAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzGrafik", ReplyAction="http://tempuri.org/IService1/PobierzGrafikResponse")]
        PrzychodniaDLL.Grafik[] PobierzGrafik(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzGrafik", ReplyAction="http://tempuri.org/IService1/PobierzGrafikResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Grafik[]> PobierzGrafikAsync(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajGrafik", ReplyAction="http://tempuri.org/IService1/DodajGrafikResponse")]
        PrzychodniaDLL.Grafik DodajGrafik(PrzychodniaDLL.Grafik grafik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajGrafik", ReplyAction="http://tempuri.org/IService1/DodajGrafikResponse")]
        System.Threading.Tasks.Task<PrzychodniaDLL.Grafik> DodajGrafikAsync(PrzychodniaDLL.Grafik grafik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunGrafik", ReplyAction="http://tempuri.org/IService1/UsunGrafikResponse")]
        bool UsunGrafik(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunGrafik", ReplyAction="http://tempuri.org/IService1/UsunGrafikResponse")]
        System.Threading.Tasks.Task<bool> UsunGrafikAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Przychodnia.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Przychodnia.ServiceReference1.IService1>, Przychodnia.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PrzychodniaDLL.Lekarz[] PobierzLekarzy() {
            return base.Channel.PobierzLekarzy();
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Lekarz[]> PobierzLekarzyAsync() {
            return base.Channel.PobierzLekarzyAsync();
        }
        
        public PrzychodniaDLL.Lekarz DodajLekarza(PrzychodniaDLL.Lekarz lekarz) {
            return base.Channel.DodajLekarza(lekarz);
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Lekarz> DodajLekarzaAsync(PrzychodniaDLL.Lekarz lekarz) {
            return base.Channel.DodajLekarzaAsync(lekarz);
        }
        
        public bool UsunLekarza(long id) {
            return base.Channel.UsunLekarza(id);
        }
        
        public System.Threading.Tasks.Task<bool> UsunLekarzaAsync(long id) {
            return base.Channel.UsunLekarzaAsync(id);
        }
        
        public PrzychodniaDLL.Pacjent[] PobierzPacjentow() {
            return base.Channel.PobierzPacjentow();
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Pacjent[]> PobierzPacjentowAsync() {
            return base.Channel.PobierzPacjentowAsync();
        }
        
        public PrzychodniaDLL.Pacjent DodajPacjenta(PrzychodniaDLL.Pacjent pacjent) {
            return base.Channel.DodajPacjenta(pacjent);
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Pacjent> DodajPacjentaAsync(PrzychodniaDLL.Pacjent pacjent) {
            return base.Channel.DodajPacjentaAsync(pacjent);
        }
        
        public bool UsunPacjenta(long id) {
            return base.Channel.UsunPacjenta(id);
        }
        
        public System.Threading.Tasks.Task<bool> UsunPacjentaAsync(long id) {
            return base.Channel.UsunPacjentaAsync(id);
        }
        
        public PrzychodniaDLL.Choroba[] PobierzChoroby() {
            return base.Channel.PobierzChoroby();
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Choroba[]> PobierzChorobyAsync() {
            return base.Channel.PobierzChorobyAsync();
        }
        
        public PrzychodniaDLL.Choroba DodajChorobe(PrzychodniaDLL.Choroba choroba) {
            return base.Channel.DodajChorobe(choroba);
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Choroba> DodajChorobeAsync(PrzychodniaDLL.Choroba choroba) {
            return base.Channel.DodajChorobeAsync(choroba);
        }
        
        public bool UsunChorobe(long id) {
            return base.Channel.UsunChorobe(id);
        }
        
        public System.Threading.Tasks.Task<bool> UsunChorobeAsync(long id) {
            return base.Channel.UsunChorobeAsync(id);
        }
        
        public PrzychodniaDLL.Lek[] PobierzLeki() {
            return base.Channel.PobierzLeki();
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Lek[]> PobierzLekiAsync() {
            return base.Channel.PobierzLekiAsync();
        }
        
        public PrzychodniaDLL.Lek DodajLek(PrzychodniaDLL.Lek lek) {
            return base.Channel.DodajLek(lek);
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Lek> DodajLekAsync(PrzychodniaDLL.Lek lek) {
            return base.Channel.DodajLekAsync(lek);
        }
        
        public bool UsunLek(long id) {
            return base.Channel.UsunLek(id);
        }
        
        public System.Threading.Tasks.Task<bool> UsunLekAsync(long id) {
            return base.Channel.UsunLekAsync(id);
        }
        
        public PrzychodniaDLL.Grafik[] PobierzGrafik(System.DateTime dateTime) {
            return base.Channel.PobierzGrafik(dateTime);
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Grafik[]> PobierzGrafikAsync(System.DateTime dateTime) {
            return base.Channel.PobierzGrafikAsync(dateTime);
        }
        
        public PrzychodniaDLL.Grafik DodajGrafik(PrzychodniaDLL.Grafik grafik) {
            return base.Channel.DodajGrafik(grafik);
        }
        
        public System.Threading.Tasks.Task<PrzychodniaDLL.Grafik> DodajGrafikAsync(PrzychodniaDLL.Grafik grafik) {
            return base.Channel.DodajGrafikAsync(grafik);
        }
        
        public bool UsunGrafik(long id) {
            return base.Channel.UsunGrafik(id);
        }
        
        public System.Threading.Tasks.Task<bool> UsunGrafikAsync(long id) {
            return base.Channel.UsunGrafikAsync(id);
        }
    }
}
