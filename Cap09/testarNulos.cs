using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;

namespace livrocsharp
{
    class testarNulos
    {
        static void TestandoNulos(string[] args)
        {
            // objeto Medico
            var med = new Medico() { ID = 1, Nome = "Rodrigo" };

            // quantos pacientes tem este médico?
            WriteLine($"Dr(a) {med.Nome} tem {med.Pacientes?.Count() ?? 0} pacientes");

            var objM = new Medico()
            {
                ID = 1,
                Nome = "Alisson",
        //             Pacientes = new List<Paciente> {
        // new Paciente{ ID=1, NomePaciente="Jeu", ValorConsulta=150},
        // new Paciente{ ID=2, NomePaciente="Lucimara", ValorConsulta=180, Remedios = "simeco plus"},
        // new Paciente{ ID=3, NomePaciente="Marcos", ValorConsulta=180, Remedios = "neosaldina"},
        // new Paciente{ ID=4, NomePaciente="Rodrigo", ValorConsulta=320, Internado = true, Historico = "pé chato" },
        // new Paciente{ ID=5, NomePaciente="Lucas", ValorConsulta=100, Internado = true, Historico = "camisa de força" },
        //             }
        //         };
                Pacientes = new List<Paciente> {
                    new Paciente{ 
                        ID=1, 
                        NomePaciente="Jeu", 
                        ValorConsulta=150},
                    new Paciente{ 
                        ID=2, 
                        NomePaciente="Lucimara", 
                        ValorConsulta=180, 
                        Remedios = "simeco plus"},
                    new Paciente{ 
                        ID=3, 
                        NomePaciente="Marcos", 
                        ValorConsulta=180, 
                        Remedios = "neosaldina"},
                    new Paciente{ 
                        ID=4, 
                        NomePaciente="Rodrigo", 
                        ValorConsulta=320, 
                        Internado = true, 
                        Historico = "pé chato" },
                    new Paciente{ 
                        ID=5, 
                        NomePaciente="Lucas", 
                        ValorConsulta=100, 
                        Internado = true, 
                        Historico = "camisa de força" },
                            }
                        };

            // listar todos os pacientes
            // nome do paciente - remédios (sem remédios) - historico
            WriteLine($"Histórico dos pacientes ---- Dr(a) {objM.Nome}");
            objM.Pacientes?.ForEach(p =>
            WriteLine($"--- {p.NomePaciente} - remédios: {p.Remedios ?? "sem remédios"} - histórico: {p.Historico} - consulta: {p.ValorConsulta:n2}"));

            // qual o faturamento da clinica?
            WriteLine($"Faturamento: {objM.Pacientes?.Sum(v => v.ValorConsulta):n2}");

            // quantos pacientes estão internados?
            WriteLine($"Qtde internados: {objM.Pacientes?.Count(i => i.Internado)}");

            // quantos pacientes tomam remédios?
            WriteLine($"Qtde tomam remédios (!=null): {objM.Pacientes?.Count(r => r.Remedios != null)}");
            WriteLine($"Qtde tomam remédios (!String): {objM.Pacientes?.Count(r => !String.IsNullOrEmpty(r.Remedios))}");

        }
    }
}