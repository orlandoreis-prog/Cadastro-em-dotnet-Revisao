﻿using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adciona aluno
                    Console.WriteLine("Informe o nome do aluno");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Informe a note do aluno");
                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                         aluno.Nota = nota;
                    }

                    else
                    {
                        throw new ArgumentException("Valor da nota deve ser decimal");
                    }    

                    alunos[indiceAluno] = aluno;
                    indiceAluno++;

                        break;
                    case "2":
                        //TODO: listar aluno
                    foreach(var a in alunos)
                    {
                        if(!string.IsNullOrEmpty(a.Nome))
                        {
                        Console.WriteLine($"ALUNO:{a.Nome} - NOTA:{a.Nota}");
                        }
                    }
                        break;
                    case "3":
                        // Calcular media geral
                        decimal notaTotal = 0;
                        var nrAlunos = 0;


                    for (int i=0; i < alunos.Length; i++)
                    {
                    if(!string.IsNullOrEmpty(alunos[i].Nome))
                    {
                        notaTotal = notaTotal + alunos[i].Nota;    
                    nrAlunos++;
                    }
                    }
                    var mediaGeral = notaTotal / nrAlunos;
                    Console.WriteLine($"MEDIA GERAL:{mediaGeral}");
                       
                        break;
                    default:

                        throw new ArgumentOutOfRangeException("Sair do Sistema");

                }

               

                opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1- inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular media geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }

}


