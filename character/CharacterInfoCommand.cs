﻿using System.Collections.Generic;
using System.Linq;
using ProjectM;

namespace v_rising_server_mod_test.character;

public static class CharacterInfoCommand {

    public static List<CharacterResponse> GetCharacters() {
        return VWorld.GetAllPlayerCharacters().Select(player =>
            new CharacterResponse(
                player.Character.Name.ToString(),
                (int) VWorld.Server.EntityManager.GetComponentData<Equipment>(player.Entity).GetFullLevel()
            )
        ).ToList();
    }
}
