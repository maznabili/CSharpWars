﻿using System;
using CSharpWars.DtoModel;
using CSharpWars.Enums;
using CSharpWars.Mapping;
using CSharpWars.Model;
using FluentAssertions;
using Xunit;

namespace CSharpWars.Tests.Mapping
{
    public class BotMapperTests
    {
        [Fact]
        public void BotMapper_Can_Map_BotModel_To_BotDto()
        {
            // Arrange
            var mapper = new BotMapper();
            var botModel = new Bot
            {
                Id = Guid.NewGuid(),
                Name = "BotName",
                LocationX = 5,
                LocationY = 6,
                Orientation = PossibleOrientations.South,
                MaximumHealth = 100,
                CurrentHealth = 98,
                MaximumStamina = 200,
                CurrentStamina = 123,
                PreviousMove = PossibleMoves.MeleeAttack
            };

            // Act
            var botDto = mapper.Map(botModel);

            // Assert
            botDto.Should().BeEquivalentTo(botModel,
                properties => properties
                    .Including(x => x.Id)
                    .Including(x => x.Name)
                    .Including(x => x.LocationX)
                    .Including(x => x.LocationY)
                    .Including(x => x.Orientation)
                    .Including(x => x.MaximumHealth)
                    .Including(x => x.CurrentHealth)
                    .Including(x => x.MaximumStamina)
                    .Including(x => x.CurrentStamina)
                    .Including(x => x.PreviousMove));
        }

        [Fact]
        public void BotMapper_Can_Map_BotDto_To_BotModel()
        {
            // Arrange
            var mapper = new BotMapper();
            var botDto = new BotDto
            {
                Id = Guid.NewGuid(),
                Name = "BotName",
                LocationX = 5,
                LocationY = 6,
                Orientation = PossibleOrientations.South,
                MaximumHealth = 100,
                CurrentHealth = 98,
                MaximumStamina = 200,
                CurrentStamina = 123,
                PreviousMove = PossibleMoves.MeleeAttack
            };

            // Act
            var botModel = mapper.Map(botDto);

            // Assert
            botModel.Should().BeEquivalentTo(botDto,
                properties => properties
                    .Including(x => x.Id)
                    .Including(x => x.Name)
                    .Including(x => x.LocationX)
                    .Including(x => x.LocationY)
                    .Including(x => x.Orientation)
                    .Including(x => x.MaximumHealth)
                    .Including(x => x.CurrentHealth)
                    .Including(x => x.MaximumStamina)
                    .Including(x => x.CurrentStamina)
                    .Including(x => x.PreviousMove));
        }
    }
}