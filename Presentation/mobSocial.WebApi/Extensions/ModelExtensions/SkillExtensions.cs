﻿using System.Linq;
using mobSocial.Data.Entity.Settings;
using mobSocial.Data.Entity.Skills;
using mobSocial.Data.Enum;
using mobSocial.Services.MediaServices;
using mobSocial.WebApi.Models.Skills;

namespace mobSocial.WebApi.Extensions.ModelExtensions
{
    public static class SkillExtensions
    {
        public static SkillModel ToModel(this Skill skill)
        {
            var model = new SkillModel()
            {
                DisplayOrder = skill.DisplayOrder,
                SkillName = skill.SkillName,
                Id = skill.Id
            };
            return model;
        }

        public static UserSkillModel ToModel(this UserSkill userSkill, IMediaService mediaService, MediaSettings mediaSettings, GeneralSettings generalSettings, bool onlySkillData = false)
        {
            var model = new UserSkillModel()
            {
                DisplayOrder = userSkill.Skill.DisplayOrder,
                SkillName = userSkill.Skill.SkillName,
                UserSkillId = userSkill.Id,
                Id = userSkill.SkillId,
                User = onlySkillData ? null : userSkill.User.ToModel(mediaService, mediaSettings),
                Media =
                    mediaService.GetEntityMedia<UserSkill>(userSkill.Id, MediaType.Video)
                        .FirstOrDefault()?.ToModel(mediaService, mediaSettings, generalSettings),
                ExternalUrl = userSkill.ExternalUrl,
                Description = userSkill.Description
            };
            return model;
        }
    }
}