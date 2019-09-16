using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQa.Mappings
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Entities.Question, Models.QuestionDto>();
            CreateMap<Entities.Question, Models.QuestionMutDto>();
            CreateMap<Models.QuestionMutDto, Entities.Question>();
        }
    }
}