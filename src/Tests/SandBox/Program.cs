namespace SandBox
{
    using CitationUniSofia.Data;
    using CitationUniSofia.Data.Common;
    using CitationUniSofia.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{typeof(Program).Namespace} ({string.Join(" ", args)}) starts working...");
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(true);

            // Seed data on application startup
            //using (var serviceScope = serviceProvider.CreateScope())
            //{
            //    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //    dbContext.Database.Migrate();
            //    new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            //}

            using (var serviceScope = serviceProvider.CreateScope())
            {
                serviceProvider = serviceScope.ServiceProvider;

                SandboxCode(serviceProvider);
            }
        }

        private static void SandboxCode(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<CitationUniSofiaContext>();

            

            //AddMetadata(db);
            //AddLanguages(db);
            //AddCountries(db);
            //AddInstitutionType(db);
            //AddPulicationType(db);
            //AddCitationType(db);
            //AddFieldScience(db);
            //AddInstitution(db);
            //AddAuthor(db);
            //AddPublication(db);
            //AddCitation(db);

        }

        private static void AddPublication(CitationUniSofiaContext db)
        {
            var languages = db.Languages.ToList();
            var countries = db.Countries.ToList();
            var authors = db.Authors.ToList();
            var publicationTypes = db.PublicationTypes.ToList();
            var institutions = db.Institutions.ToList();
            var areasScience = db.AreasScience.ToList();
            var metadata = db.Metadata.ToList();

            var rnd = new Random();

            var publication = new Publication
            {
                ISSN = "0861-1815",
                Title = "Съвременно право",
                IndexedResource = "Определенията по чл. 306, ал. 1, Т. 1-3 НПК",
                Detail = "с. 65-86",
                Summary = "The institute of resolving the matters under Art. 306, para 1, subparas 1-3 of the Criminal Procedure Code (CPC) through a ruling plays a dual role and has its own importance in the criminal procedure. This institute is applied to a specific case in the event that the court has failed to judge on the said matters through the sentence, and is applied separately as well, namely, for determining the total punishment where there are several sentences having the force of res judicata. The proceedings of rendering such a ruling and the control over its propriety give rise to certain theoretical and practical questions, which form the subject matter of the study. ",
                PublicationTypeId = publicationTypes[0].Id,
                PublicationType = publicationTypes[0],
                LanguageId = languages[0].Id,
                Language = languages[0],
                CountryId = countries[0].Id,
                Country = countries[0],
                InstitutionId = institutions[0].Id,
                Institution = institutions[0]
            };
            publication.PublicationsMetadata.Add(new PublicationMetadata
            {
                Publication = publication,
                Metadata = metadata[0]
            });

            publication.PublicationsAreasScience.Add(new PublicationAreaScience
            {
                Publication = publication,
                AreaScience = areasScience[0]
            });

            publication.PublicationsAuthors.Add(new PublicationAuthor
            {
                Publication = publication,
                Author = authors[0]
            });

            db.Publications.Add(publication);
            db.SaveChanges();
        }

        private static void AddCitation(CitationUniSofiaContext db)
        {
            var sequence = db.Citations.Count() + 1;
            var citType = db.CitationTypes.FirstOrDefault();
            var author = db.Authors.FirstOrDefault();
            var institution = db.Institutions.FirstOrDefault();
            var publication = db.Publications.FirstOrDefault();

            var citation = new Citation
            {
                Sequence = sequence,
                Name = "Българско наказателно-процесуално право : Т. 2",
                Year = "1937",
                Detail = "София : Печ. Художник",
                Pages = "с. 434",
                CitationTypeId = citType.Id,
                CitationType = citType,
                AuthorId = author.Id,
                Author = author,
                InstitutionId = institution.Id,
                Institution = institution
            };
            var publCitation = new PublicationCitation
            {
                Publication = publication,
                Citation = citation
            };

            citation.PublicationsCitations.Add(publCitation);

            db.Citations.Add(citation);
            db.SaveChanges();
        }

        private static void AddInstitution(CitationUniSofiaContext db)
        {
            var institutionType = db.InstitutionsTypes.ToList();

            var institutionSU = new Institution
            {
                InstitutionTypeId = institutionType[0].Id,
                InstitutionType = institutionType[0],
                Name = "Софийски университет \"Свети Климент Охридски\"",
                AlternativeName = "СУ \"Св. Кл. Охридски\"",
                WWW = "https://www.uni-sofia.bg/",
                Address = "бул. \"Цар Освободител\" 15, 1504 Център, София"
            };

            db.Institutions.Add(institutionSU);

            var institutionBan = new Institution
            {
                InstitutionTypeId = institutionType[1].Id,
                InstitutionType = institutionType[1],
                Name = "Българската академия на науките",
                AlternativeName = "БАН",
                WWW = "http://www.bas.bg/",
                Address = "София, 1040, ул. \"15 ноември\", №1"
            };

            db.Institutions.Add(institutionBan);

            var institutionCibi = new Institution
            {
                InstitutionTypeId = institutionType[2].Id,
                InstitutionType = institutionType[2],
                Name = "Сиби",
                AlternativeName = "Sibi",
                WWW = "http://sibi.bg/",
                Address = "пл. „Славейков“ № 4, ет. 4, 1000 София"
            };

            db.Institutions.Add(institutionCibi);


            var institutionNB = new Institution
            {
                InstitutionTypeId = institutionType[3].Id,
                InstitutionType = institutionType[3],
                Name = "Национална библиотека \"Св.св.Кирил и Методий\"",
                AlternativeName = "\"St. St. Cyrill and Methodius\" National Library",
                WWW = "http://www.nationallibrary.bg/wp/",
                Address = "София 1504, бул. \"Васил Левски\" 88"
            };

            db.Institutions.Add(institutionNB);
            db.SaveChanges();

        }

        private static void AddAuthor(CitationUniSofiaContext db)
        {
            var authorsCollection = new List<Author>();
            var authorsNames = new Dictionary<string, string>();
            var insitution = db.Institutions.ToList();
            var rnd = new Random();

            authorsNames["Саранов, Никола Иванов"] = "Saranov, Nikola Ivanov";
            authorsNames["Митов, Георги Иванов"] = "Mitov, Georgi Ivanov";
            authorsNames["Велчев, Светослав Петров"] = "Velchev, Svetoslav Petrov";
            authorsNames["Ненков, Румен"] = "Nenkov, Rumen";

            foreach (var name in authorsNames)
            {
                var currAuthor = new Author
                {
                    Name = name.Key,
                    TransliterationName = name.Value
                };

                db.AuthorsInstitutions.Add(new AuthorInstitution
                {
                    Author = currAuthor,
                    Institution = insitution[rnd.Next(0, insitution.Count)]
                });

                authorsCollection.Add(currAuthor);
            }

            db.Authors.AddRange(authorsCollection);
            db.SaveChanges();
        }

        private static void AddMetadata(CitationUniSofiaContext db)
        {
            var metadata = new string[]
            {
                "медицина",
                "здраве",
                "право",
                "дело",
                "изчисления",
                "математика"
            };


            var metadataCollection = new List<Metadata>();

            foreach (var md in metadata)
            {
                var currMd = new Metadata
                {
                    Name = md
                };

                metadataCollection.Add(currMd);
            }

            db.Metadata.AddRange(metadataCollection);
            db.SaveChanges();
        }

        private static void AddCitationType(CitationUniSofiaContext db)
        {
            var citationType = new string[]
            {
                "Книгa",
                "Сборници и енциклопедии",
                "Официални и служебни издания",
                "Стандарти",
                "Електронни книги",
                "Глави или части от книги и сборници",
                "Дипломни работи и дисертации"
            };


            var citationTypeCollection = new List<CitationType>();

            foreach (var ct in citationType)
            {
                var currCt = new CitationType
                {
                    Name = ct
                };

                citationTypeCollection.Add(currCt);
            }

            db.CitationTypes.AddRange(citationTypeCollection);
            db.SaveChanges();
        }

        private static void AddFieldScience(CitationUniSofiaContext db)
        {
            var fieldsSciences = new Dictionary<string, List<string>>();

            fieldsSciences["Хуманитарни науки и изкуства"] = new List<string>()
            {
               "История и археология",
               "Философия",
               "Религия и теология",
               "Теория на изкуствата",
               "Изобразително изкуство",
               "Музикално и танцово изкуство",
               "Театрално и филмово изкуство"

            };

            fieldsSciences["Социални, стопански и правни науки"] = new List<string>()
            {
                "Социология, антропология и науки за културата",
                "Психология",
                "Политически науки",
                "Социални дейности",
                "Обществени комуникации и информационни науки",
                "Право",
                "Администрация и управление",
                "Икономика",
                "Туризъм",
                "Теория и управление на образованието",
                "Педагогика",
                "Педагогика на обучението по"
            };

            fieldsSciences["Природни науки, математика и информатика"] = new List<string>()
            {
                "Машинно инженерство",
                "Електротехника, електроника и автоматика",
                "Комуникационна и компютърна техника",
                "Енергетика",
                "Транспорт, корабоплаване и авиация",
                "Материали и материалознание",
                "Архитектура, строителство и геодезия",
                "Проучване, добив и обработка на полезни изкопаеми",
                "Химични технологии",
                "Биотехнологии",
                "Хранителни технологии",
                "Общо инженерство"
            };

            fieldsSciences["Технически науки"] = new List<string>()
            {
                "Машинно инженерство",
                "Електротехника, електроника и автоматика",
                "Комуникационна и компютърна техника",
                "Енергетика",
                "Транспорт, корабоплаване и авиация",
                "Материали и материалознание",
                "Архитектура, строителство и геодезия",
                "Проучване, добив и обработка на полезни изкопаеми",
                "Химични технологии",
                "Биотехнологии",
                "Хранителни технологии",
                "Общо инженерство"

            };

            fieldsSciences["Аграрни науки и ветеринарна"] = new List<string>()
            {
                "Растениевъдство",
                "Растителна защита",
                "Животновъдство",
                "Ветеринарна медицина",
                "Горско стопанство"
            };

            fieldsSciences["Медицина"] = new List<string>()
            {
               "Медицина",
               "Стоматология",
               "Фармация",
               "Обществено здраве",
               "Здравни грижи",
               "Спорт",

            };

            fieldsSciences["Здравеопазване и спорт"] = new List<string>();


            var fieldsSciencesCollection = new List<FieldScience>();

            foreach (var fs in fieldsSciences)
            {
                var currFs = new FieldScience
                {
                    Name = fs.Key
                };

                fs.Value.ForEach(fa => currFs.AreasScience.Add(new AreaScience
                {
                    Name = fa
                }));

                fieldsSciencesCollection.Add(currFs);
            }

            db.FieldsSciences.AddRange(fieldsSciencesCollection);
            db.SaveChanges();
        }

        private static void AddPulicationType(CitationUniSofiaContext db)
        {
            var publicationType = new string[]
            {
                "Статия",
                "Публикация",
                "Монография",
                "Доклади"
            };

            var publicationTypeCollection = new List<PublicationType>();

            foreach (var publ in publicationType)
            {
                var currPubl = new PublicationType
                {
                    Name = publ
                };

                publicationTypeCollection.Add(currPubl);
            }

            db.PublicationTypes.AddRange(publicationTypeCollection);
            db.SaveChanges();
        }

        private static void AddInstitutionType(CitationUniSofiaContext db)
        {
            var institutionType = new string[]
            {
                "Университет",
                "Академия",
                "Дружество",
                "Библиотека"
            };

            var institutionTypeCollection = new List<InstitutionType>();

            foreach (var inst in institutionType)
            {
                var currInst = new InstitutionType
                {
                    Name = inst
                };

                institutionTypeCollection.Add(currInst);
            }

            db.InstitutionsTypes.AddRange(institutionTypeCollection);
            db.SaveChanges();
        }

        private static void AddCountries(CitationUniSofiaContext db)
        {
            var countries = new string[]
            {
                "България",
                "Русия",
                "Германия",
                "Франция",
                "Англия"
            };


            var countriesCollection = new List<Country>();

            foreach (var cnt in countries)
            {
                var currCountry = new Country
                {
                    Name = cnt
                };

                countriesCollection.Add(currCountry);
            }

            db.Countries.AddRange(countriesCollection);
            db.SaveChanges();
        }

        private static void AddLanguages(CitationUniSofiaContext db)
        {
            var languages = new string[]
            {
                "Английски",
                "Български",
                "Немски",
                "Френски",
                "Руски",
                "Испански"
            };

            var languagesCollection = new List<Language>();

            foreach (var lng in languages)
            {
                var currLng = new Language
                {
                    Name = lng
                };

                languagesCollection.Add(currLng);
            }

            db.Languages.AddRange(languagesCollection);
            db.SaveChanges();
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            services.AddDbContext<CitationUniSofiaContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));


            //Application services
            services.AddScoped(typeof(IRepository<>), typeof(DbRepository<>));

        }
    }
}
