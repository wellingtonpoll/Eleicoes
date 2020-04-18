using System.Collections.Generic;
using Eleicoes.Domain.Entities;
using FizzWare.NBuilder;

namespace Eleicoes.Infra.Data.Builders
{
    public class CandidatoBuilder
    {
        public IEnumerable<Candidato> BuildList(string anoEleicao)
        {
            var builder = Builder<Candidato>.CreateListOfSize(10).All()
                .WithFactory(() => 
                    new Candidato(
                        id: Faker.RandomNumber.Next(),
                        numeroCandidato: Faker.RandomNumber.Next(),
                        anoeleicao: anoEleicao,
                        nome: Faker.Name.FullName(),
                        nascimento: Faker.DateOfBirth.Next(),
                        cpf: Faker.Identification.UKNationalInsuranceNumber(),
                        email: Faker.Internet.Email(),
                        agremiacao: Faker.Name.Suffix(),
                        ufNascimento: Faker.Address.CityPrefix(),
                        municipioNascimento: Faker.Address.CitySufix(),
                        tituloEleitor: Faker.RandomNumber.Next().ToString(),
                        genero: new Genero(
                            id: Faker.RandomNumber.Next(),
                            descricao: "Masculino"
                        ),
                        grauInstrucao: new GrauInstrucao(
                            id: Faker.RandomNumber.Next(),
                            descricao: Faker.Lorem.Sentence()
                        ),
                        estadoCivil: new EstadoCivil(
                            id: Faker.RandomNumber.Next(),
                            descricao: Faker.Lorem.Sentence()
                        ),
                        ocupacao: new Ocupacao(
                            id: Faker.RandomNumber.Next(),
                            descricao: Faker.Lorem.Sentence()
                        ),
                        cargo: new Cargo(
                            id: Faker.RandomNumber.Next(),
                            descricao: Faker.Lorem.Sentence(),
                            uf: Faker.Address.CityPrefix(),
                            estado: Faker.Address.CitySufix()
                        ),
                        coligacao: new Coligacao(
                            id: Faker.RandomNumber.Next(),
                            nome: Faker.Name.Prefix(),
                            composicao: Faker.Name.Prefix()
                        ),
                        partido: new Partido(
                            numero: Faker.RandomNumber.Next(),
                            sigla: Faker.Name.Prefix(),
                            nome: Faker.Name.Last()
                        ),
                        situacaoCandidatura: new SituacaoCandidatura(
                            id: Faker.RandomNumber.Next(),
                            descricao: Faker.Lorem.Sentence(),
                            detalhe: Faker.Lorem.Sentence()
                        )
                    ));
            return builder.Build();
        }
    }
}