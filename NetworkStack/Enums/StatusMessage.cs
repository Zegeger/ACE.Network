////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// Set of predefined status messages, some of which take additional data as input
    /// </summary>
    public enum StatusMessage : uint
    {
        
        /// <summary>
        /// You failed to go to non-combat mode.
        /// </summary>
        Unknown1 = 0x00000017,
        
        /// <summary>
        /// You're too busy!
        /// </summary>
        Unknown2 = 0x0000001D,
        
        /// <summary>
        ///  is too busy to accept gifts right now.\n
        /// </summary>
        Unknown3 = 0x0000001E,
        
        /// <summary>
        /// You must control both objects!
        /// </summary>
        Unknown4 = 0x00000020,
        
        /// <summary>
        /// Unable to move to object!
        /// </summary>
        Unknown5 = 0x00000023,
        
        /// <summary>
        /// You can't jump while in the air
        /// </summary>
        Unknown6 = 0x00000024,
        
        /// <summary>
        /// That is not a valid command.
        /// </summary>
        Unknown7 = 0x00000026,
        
        /// <summary>
        /// The item is under someone else's control!
        /// </summary>
        Unknown8 = 0x00000028,
        
        /// <summary>
        /// You cannot pick that up!
        /// </summary>
        Unknown9 = 0x00000029,
        
        /// <summary>
        /// You are too encumbered to carry that!
        /// </summary>
        Unknown10 = 0x0000002A,
        
        /// <summary>
        ///  cannot carry anymore.\n
        /// </summary>
        Unknown11 = 0x0000002B,
        
        /// <summary>
        /// Action cancelled!
        /// </summary>
        Unknown12 = 0x00000036,
        
        /// <summary>
        /// Unable to move to object!
        /// </summary>
        Unknown13 = 0x00000037,
        
        /// <summary>
        /// Unable to move to object!
        /// </summary>
        Unknown14 = 0x00000038,
        
        /// <summary>
        /// Unable to move to object!
        /// </summary>
        Unknown15 = 0x00000039,
        
        /// <summary>
        /// You can't do that... you're dead!
        /// </summary>
        Unknown16 = 0x0000003A,
        
        /// <summary>
        /// You charged too far!
        /// </summary>
        Unknown17 = 0x0000003D,
        
        /// <summary>
        /// You are too tired to do that!
        /// </summary>
        Unknown18 = 0x0000003E,
        
        /// <summary>
        /// The container is closed!
        /// </summary>
        Unknown19 = 0x000003EE,
        
        /// <summary>
        ///  is not accepting gifts right now.\n
        /// </summary>
        Unknown20 = 0x000003EF,
        
        /// <summary>
        /// You failed to go to non-combat mode.
        /// </summary>
        Unknown21 = 0x000003F1,
        
        /// <summary>
        /// You are too fatigued to attack!
        /// </summary>
        Unknown22 = 0x000003F7,
        
        /// <summary>
        /// You are out of ammunition!
        /// </summary>
        Unknown23 = 0x000003F8,
        
        /// <summary>
        /// Your missile attack misfired!
        /// </summary>
        Unknown24 = 0x000003F9,
        
        /// <summary>
        /// You've attempted an impossible spell path!
        /// </summary>
        Unknown25 = 0x000003FA,
        
        /// <summary>
        /// You don't know that spell!
        /// </summary>
        Unknown26 = 0x000003FE,
        
        /// <summary>
        /// Incorrect target type
        /// </summary>
        Unknown27 = 0x000003FF,
        
        /// <summary>
        /// You don't have all the components for this spell.
        /// </summary>
        Unknown28 = 0x00000400,
        
        /// <summary>
        /// You don't have enough Mana to cast this spell.
        /// </summary>
        Unknown29 = 0x00000401,
        
        /// <summary>
        /// Your spell fizzled.\n
        /// </summary>
        Unknown30 = 0x00000402,
        
        /// <summary>
        /// Your spell's target is missing!
        /// </summary>
        Unknown31 = 0x00000403,
        
        /// <summary>
        /// Your projectile spell mislaunched!
        /// </summary>
        Unknown32 = 0x00000404,
        
        /// <summary>
        /// Your spell cannot be cast outside
        /// </summary>
        Unknown33 = 0x00000407,
        
        /// <summary>
        /// Your spell cannot be cast inside
        /// </summary>
        Unknown34 = 0x00000408,
        
        /// <summary>
        /// You are unprepared to cast a spell
        /// </summary>
        Unknown35 = 0x0000040A,
        
        /// <summary>
        /// You've already sworn your Allegiance
        /// </summary>
        Unknown36 = 0x0000040B,
        
        /// <summary>
        /// You don't have enough experience available to swear Allegiance
        /// </summary>
        Unknown37 = 0x0000040C,
        
        /// <summary>
        /// %s is already one of your followers
        /// </summary>
        Unknown38 = 0x00000413,
        
        /// <summary>
        /// You are not in an allegiance!
        /// </summary>
        Unknown39 = 0x00000414,
        
        /// <summary>
        /// %s cannot have any more Vassals
        /// </summary>
        Unknown40 = 0x00000416,
        
        /// <summary>
        /// You must be the leader of a Fellowship
        /// </summary>
        Unknown41 = 0x0000041D,
        
        /// <summary>
        /// Your Fellowship is full
        /// </summary>
        Unknown42 = 0x0000041E,
        
        /// <summary>
        /// That Fellowship name is not permitted
        /// </summary>
        Unknown43 = 0x0000041F,
        
        /// <summary>
        /// That channel doesn't exist.
        /// </summary>
        Unknown44 = 0x00000422,
        
        /// <summary>
        /// You can't use that channel.
        /// </summary>
        Unknown45 = 0x00000423,
        
        /// <summary>
        /// You're already on that channel.
        /// </summary>
        Unknown46 = 0x00000424,
        
        /// <summary>
        /// You're not currently on that channel.
        /// </summary>
        Unknown47 = 0x00000425,
        
        /// <summary>
        /// You cannot merge different stacks!
        /// </summary>
        Unknown48 = 0x00000427,
        
        /// <summary>
        /// You cannot merge enchanted items!
        /// </summary>
        Unknown49 = 0x00000428,
        
        /// <summary>
        /// You must control at least one stack!
        /// </summary>
        Unknown50 = 0x00000429,
        
        /// <summary>
        /// Your craft attempt fails.
        /// </summary>
        Unknown51 = 0x00000432,
        
        /// <summary>
        /// Your craft attempt fails.
        /// </summary>
        Unknown52 = 0x00000433,
        
        /// <summary>
        /// Given that number of items, you cannot craft anything.
        /// </summary>
        Unknown53 = 0x00000434,
        
        /// <summary>
        /// Your craft attempt fails.
        /// </summary>
        Unknown54 = 0x00000435,
        
        /// <summary>
        /// Either you or one of the items involved does not pass the requirements for this craft interaction.
        /// </summary>
        Unknown55 = 0x00000437,
        
        /// <summary>
        /// You do not have all the neccessary items.
        /// </summary>
        Unknown56 = 0x00000438,
        
        /// <summary>
        /// Not all the items are avaliable.
        /// </summary>
        Unknown57 = 0x00000439,
        
        /// <summary>
        /// You must be at rest in peace mode to do trade skills.
        /// </summary>
        Unknown58 = 0x0000043A,
        
        /// <summary>
        /// You are not trained in that trade skill.
        /// </summary>
        Unknown59 = 0x0000043B,
        
        /// <summary>
        /// Your hands must be free.
        /// </summary>
        Unknown60 = 0x0000043C,
        
        /// <summary>
        /// You cannot link to that portal!\n
        /// </summary>
        Unknown61 = 0x0000043D,
        
        /// <summary>
        /// You have solved this quest too recently!\n
        /// </summary>
        Unknown62 = 0x0000043E,
        
        /// <summary>
        /// You have solved this quest too many times!\n
        /// </summary>
        Unknown63 = 0x0000043F,
        
        /// <summary>
        /// This item requires you to complete a specific quest before you can pick it up!\n
        /// </summary>
        Unknown64 = 0x00000445,
        
        /// <summary>
        /// Player killers may not interact with that portal!\n
        /// </summary>
        Unknown65 = 0x0000045C,
        
        /// <summary>
        /// Non-player killers may not interact with that portal!\n
        /// </summary>
        Unknown66 = 0x0000045D,
        
        /// <summary>
        /// You do not own a house!
        /// </summary>
        Unknown67 = 0x0000045E,
        
        /// <summary>
        /// You do not own a house!
        /// </summary>
        Unknown68 = 0x0000045F,
        
        /// <summary>
        /// You must purchase Asheron's Call: Dark Majesty to interact with that portal.\n
        /// </summary>
        Unknown69 = 0x00000466,
        
        /// <summary>
        /// You have used all the hooks you are allowed to use for this house.\n
        /// </summary>
        Unknown70 = 0x00000469,
        
        /// <summary>
        ///  doesn't know what to do with that.\n
        /// </summary>
        Unknown71 = 0x0000046A,
        
        /// <summary>
        /// You must complete a quest to interact with that portal.\n
        /// </summary>
        Unknown72 = 0x00000474,
        
        /// <summary>
        /// You must own a house to use this command.
        /// </summary>
        Unknown73 = 0x0000047F,
        
        /// <summary>
        /// You can't jump from this position
        /// </summary>
        Unknown74 = 0x0000048,
        
        /// <summary>
        /// Your monarch does not own a mansion or a villa!
        /// </summary>
        Unknown75 = 0x00000480,
        
        /// <summary>
        /// Your monarch does not own a mansion or a villa!
        /// </summary>
        Unknown76 = 0x00000481,
        
        /// <summary>
        /// Your monarch has closed the mansion to the Allegiance.
        /// </summary>
        Unknown77 = 0x00000482,
        
        /// <summary>
        /// You must be above level %s to purchase this dwelling.\n
        /// </summary>
        Unknown78 = 0x00000488,
        
        /// <summary>
        /// You must be at or below level %s to purchase this dwelling.\n
        /// </summary>
        Unknown79 = 0x00000489,
        
        /// <summary>
        /// You must be a monarch to purchase this dwelling.\n
        /// </summary>
        Unknown80 = 0x0000048A,
        
        /// <summary>
        /// You must be above allegiance rank %s to purchase this dwelling.\n
        /// </summary>
        Unknown81 = 0x0000048B,
        
        /// <summary>
        /// You must be at or below allegiance rank %s to purchase this dwelling.\n
        /// </summary>
        Unknown82 = 0x0000048C,
        
        /// <summary>
        /// Your offer of Allegiance has been ignored.
        /// </summary>
        Unknown83 = 0x0000048E,
        
        /// <summary>
        /// You are already involved in something!
        /// </summary>
        Unknown84 = 0x0000048F,
        
        /// <summary>
        /// You're too loaded down to jump
        /// </summary>
        Unknown85 = 0x0000049,
        
        /// <summary>
        /// You must be a monarch to use this command.
        /// </summary>
        Unknown86 = 0x00000490,
        
        /// <summary>
        /// You must specify a character to boot.
        /// </summary>
        Unknown87 = 0x00000491,
        
        /// <summary>
        /// You can't boot yourself!
        /// </summary>
        Unknown88 = 0x00000492,
        
        /// <summary>
        /// That character does not exist.
        /// </summary>
        Unknown89 = 0x00000493,
        
        /// <summary>
        /// That person is not a member of your Allegiance!
        /// </summary>
        Unknown90 = 0x00000494,
        
        /// <summary>
        /// No patron from which to break!
        /// </summary>
        Unknown91 = 0x00000495,
        
        /// <summary>
        /// Your Allegiance has been dissolved!\n
        /// </summary>
        Unknown92 = 0x00000496,
        
        /// <summary>
        /// Your patron's Allegiance to you has been broken!\n
        /// </summary>
        Unknown93 = 0x00000497,
        
        /// <summary>
        /// You have moved too far!
        /// </summary>
        Unknown94 = 0x00000498,
        
        /// <summary>
        /// That is not a valid destination!
        /// </summary>
        Unknown95 = 0x00000499,
        
        /// <summary>
        /// You must purchase Asheron's Call -- Dark Majesty to use this function.
        /// </summary>
        Unknown96 = 0x0000049A,
        
        /// <summary>
        /// You fail to link with the lifestone!\n
        /// </summary>
        Unknown97 = 0x0000049B,
        
        /// <summary>
        /// You wandered too far to link with the lifestone!\n
        /// </summary>
        Unknown98 = 0x0000049C,
        
        /// <summary>
        /// You successfully link with the lifestone!\n
        /// </summary>
        Unknown99 = 0x0000049D,
        
        /// <summary>
        /// You must have linked with a lifestone in order to recall to it!\n
        /// </summary>
        Unknown100 = 0x0000049E,
        
        /// <summary>
        /// You fail to recall to the lifestone!\n
        /// </summary>
        Unknown101 = 0x0000049F,
        
        /// <summary>
        /// Ack! You killed yourself!\n
        /// </summary>
        Unknown102 = 0x000004A,
        
        /// <summary>
        /// You fail to link with the portal!\n
        /// </summary>
        Unknown103 = 0x000004A0,
        
        /// <summary>
        /// You successfully link with the portal!\n
        /// </summary>
        Unknown104 = 0x000004A1,
        
        /// <summary>
        /// You fail to recall to the portal!\n
        /// </summary>
        Unknown105 = 0x000004A2,
        
        /// <summary>
        /// You must have linked with a portal in order to recall to it!\n
        /// </summary>
        Unknown106 = 0x000004A3,
        
        /// <summary>
        /// You fail to summon the portal!\n
        /// </summary>
        Unknown107 = 0x000004A4,
        
        /// <summary>
        /// You must have linked with a portal in order to summon it!\n
        /// </summary>
        Unknown108 = 0x000004A5,
        
        /// <summary>
        /// You fail to teleport!\n
        /// </summary>
        Unknown109 = 0x000004A6,
        
        /// <summary>
        /// You have been teleported too recently!\n
        /// </summary>
        Unknown110 = 0x000004A7,
        
        /// <summary>
        /// You must be an Advocate to interact with that portal.\n
        /// </summary>
        Unknown111 = 0x000004A8,
        
        /// <summary>
        /// Players may not interact with that portal.\n
        /// </summary>
        Unknown112 = 0x000004AA,
        
        /// <summary>
        /// You are not powerful enough to interact with that portal!\n
        /// </summary>
        Unknown113 = 0x000004AB,
        
        /// <summary>
        /// You are too powerful to interact with that portal!\n
        /// </summary>
        Unknown114 = 0x000004AC,
        
        /// <summary>
        /// You cannot recall to that portal!\n
        /// </summary>
        Unknown115 = 0x000004AD,
        
        /// <summary>
        /// You cannot summon that portal!\n
        /// </summary>
        Unknown116 = 0x000004AE,
        
        /// <summary>
        /// The lock is already unlocked.
        /// </summary>
        Unknown117 = 0x000004AF,
        
        /// <summary>
        /// You can't lock or unlock that!
        /// </summary>
        Unknown118 = 0x000004B0,
        
        /// <summary>
        /// You can't lock or unlock what is open!
        /// </summary>
        Unknown119 = 0x000004B1,
        
        /// <summary>
        /// The key doesn't fit this lock.\n
        /// </summary>
        Unknown120 = 0x000004B2,
        
        /// <summary>
        /// The lock has been used too recently.
        /// </summary>
        Unknown121 = 0x000004B3,
        
        /// <summary>
        /// You aren't trained in lockpicking!
        /// </summary>
        Unknown122 = 0x000004B4,
        
        /// <summary>
        /// You must specify a character to query.
        /// </summary>
        Unknown123 = 0x000004B5,
        
        /// <summary>
        /// Please use the allegiance panel to view your own information.
        /// </summary>
        Unknown124 = 0x000004B6,
        
        /// <summary>
        /// You have used that command too recently.
        /// </summary>
        Unknown125 = 0x000004B7,
        
        /// <summary>
        /// SendNotice_AbuseReportResponse
        /// </summary>
        Unknown126 = 0x000004B8,
        
        /// <summary>
        /// SendNotice_AbuseReportResponse
        /// </summary>
        Unknown127 = 0x000004B9,
        
        /// <summary>
        /// SendNotice_AbuseReportResponse
        /// </summary>
        Unknown128 = 0x000004BA,
        
        /// <summary>
        /// You do not own that salvage tool!\n
        /// </summary>
        Unknown129 = 0x000004BD,
        
        /// <summary>
        /// You do not own that item!\n
        /// </summary>
        Unknown130 = 0x000004BE,
        
        /// <summary>
        /// The %s was not suitable for salvaging.
        /// </summary>
        Unknown131 = 0x000004BF,
        
        /// <summary>
        /// The %s contains the wrong material.
        /// </summary>
        Unknown132 = 0x000004C0,
        
        /// <summary>
        /// The material cannot be created.\n
        /// </summary>
        Unknown133 = 0x000004C1,
        
        /// <summary>
        /// The list of items you are attempting to salvage is invalid.\n
        /// </summary>
        Unknown134 = 0x000004C2,
        
        /// <summary>
        /// You cannot salvage items that you are trading!\n
        /// </summary>
        Unknown135 = 0x000004C3,
        
        /// <summary>
        /// You must be a guest in this house to interact with that portal.\n
        /// </summary>
        Unknown136 = 0x000004C4,
        
        /// <summary>
        /// Your Allegiance Rank is too low to use that item's magic.
        /// </summary>
        Unknown137 = 0x000004C5,
        
        /// <summary>
        /// You must be %s to use that item's magic.
        /// </summary>
        Unknown138 = 0x000004C6,
        
        /// <summary>
        /// Your Arcane Lore skill is too low to use that item's magic.
        /// </summary>
        Unknown139 = 0x000004C7,
        
        /// <summary>
        /// That item doesn't have enough Mana.
        /// </summary>
        Unknown140 = 0x000004C8,
        
        /// <summary>
        /// Your %s is too low to use that item's magic.
        /// </summary>
        Unknown141 = 0x000004C9,
        
        /// <summary>
        /// Only %s may use that item's magic.
        /// </summary>
        Unknown142 = 0x000004CA,
        
        /// <summary>
        /// You must have %s specialized to use that item's magic.
        /// </summary>
        Unknown143 = 0x000004CB,
        
        /// <summary>
        /// You have been involved in a player killer battle too recently to do that!\n
        /// </summary>
        Unknown144 = 0x000004CC,
        
        /// <summary>
        ///  is too busy to accept gifts right now.\n
        /// </summary>
        Unknown145 = 0x000004CE,
        
        /// <summary>
        ///  cannot accept stacked objects. Try giving one at a time.\n
        /// </summary>
        Unknown146 = 0x000004CF,
        
        /// <summary>
        /// Invalid PK status!
        /// </summary>
        Unknown147 = 0x000004D,
        
        /// <summary>
        /// You have failed to alter your skill.\n
        /// </summary>
        Unknown148 = 0x000004D0,
        
        /// <summary>
        /// Your %s skill must be trained, not untrained or specialized, in order to be altered in this way!\n
        /// </summary>
        Unknown149 = 0x000004D1,
        
        /// <summary>
        /// You do not have enough skill credits to specialize your %s skill.\n
        /// </summary>
        Unknown150 = 0x000004D2,
        
        /// <summary>
        /// You have too many available experience points to be able to absorb the experience points from your %s skill. Please spend some of your experience points and try again.\n
        /// </summary>
        Unknown151 = 0x000004D3,
        
        /// <summary>
        /// Your %s skill is already untrained!\n
        /// </summary>
        Unknown152 = 0x000004D4,
        
        /// <summary>
        /// You are currently wielding items which require a certain level of %s.  Your %s skill cannot be lowered while you are wielding these items.  Please remove these items and try again.\n
        /// </summary>
        Unknown153 = 0x000004D5,
        
        /// <summary>
        /// You have succeeded in specializing your %s skill!\n
        /// </summary>
        Unknown154 = 0x000004D6,
        
        /// <summary>
        /// You have succeeded in lowering your %s skill from specialized to trained!\n
        /// </summary>
        Unknown155 = 0x000004D7,
        
        /// <summary>
        /// You have succeeded in untraining your %s skill!\n
        /// </summary>
        Unknown156 = 0x000004D8,
        
        /// <summary>
        /// Although you cannot untrain your %s skill, you have succeeded in recovering all the experience you had invested in it.\n
        /// </summary>
        Unknown157 = 0x000004D9,
        
        /// <summary>
        /// You have too many credits invested in specialized skills already! Before you can specialize your %s skill, you will need to unspecialize some other skill.\n
        /// </summary>
        Unknown158 = 0x000004DA,
        
        /// <summary>
        /// You have failed to alter your attributes.\n
        /// </summary>
        Unknown159 = 0x000004DD,
        
        /// <summary>
        /// \n
        /// </summary>
        Unknown160 = 0x000004DE,
        
        /// <summary>
        /// \n
        /// </summary>
        Unknown161 = 0x000004DF,
        
        /// <summary>
        /// You fail to affect %s because you cannot affect anyone!\n
        /// </summary>
        Unknown162 = 0x000004E,
        
        /// <summary>
        /// You are currently wielding items which require a certain level of skill. Your attributes cannot be transferred while you are wielding these items. Please remove these items and try again.\n
        /// </summary>
        Unknown163 = 0x000004E0,
        
        /// <summary>
        /// You have succeeded in transferring your attributes!\n
        /// </summary>
        Unknown164 = 0x000004E1,
        
        /// <summary>
        /// This hook is a duplicated housing object. You may not add items to a duplicated housing object. Please empty the hook and allow it to reset.\n
        /// </summary>
        Unknown165 = 0x000004E2,
        
        /// <summary>
        /// That item is of the wrong type to be placed on this hook.\n
        /// </summary>
        Unknown166 = 0x000004E3,
        
        /// <summary>
        /// This chest is a duplicated housing object. You may not add items to a duplicated housing object. Please empty everything -- including backpacks -- out of the chest and allow the chest to reset.\n
        /// </summary>
        Unknown167 = 0x000004E4,
        
        /// <summary>
        /// This hook was a duplicated housing object. Since it is now empty, it will be deleted momentarily. Once it is gone, it is safe to use the other, non-duplicated hook that is here.\n
        /// </summary>
        Unknown168 = 0x000004E5,
        
        /// <summary>
        /// This chest was a duplicated housing object. Since it is now empty, it will be deleted momentarily. Once it is gone, it is safe to use the other, non-duplicated chest that is here.\n
        /// </summary>
        Unknown169 = 0x000004E6,
        
        /// <summary>
        /// You cannot swear allegiance to anyone because you own a monarch-only house. Please abandon your house and try again.\n
        /// </summary>
        Unknown170 = 0x000004E7,
        
        /// <summary>
        /// The %s cannot be used while on a hook and only the owner may open the hook.\n
        /// </summary>
        Unknown171 = 0x000004E8,
        
        /// <summary>
        /// The %s cannot be used while on a hook, use the '@house hooks on' command to make the hook openable.\n
        /// </summary>
        Unknown172 = 0x000004E9,
        
        /// <summary>
        /// The %s can only be used while on a hook.\n
        /// </summary>
        Unknown173 = 0x000004EA,
        
        /// <summary>
        /// You can't do that while in the air!
        /// </summary>
        Unknown174 = 0x000004EB,
        
        /// <summary>
        /// You cannot modify your player killer status while you are recovering from a PK death.\n
        /// </summary>
        Unknown175 = 0x000004EC,
        
        /// <summary>
        /// Advocates may not change their player killer status!\n
        /// </summary>
        Unknown176 = 0x000004ED,
        
        /// <summary>
        /// Your level is too low to change your player killer status with this object.\n
        /// </summary>
        Unknown177 = 0x000004EE,
        
        /// <summary>
        /// Your level is too high to change your player killer status with this object.\n
        /// </summary>
        Unknown178 = 0x000004EF,
        
        /// <summary>
        /// You fail to affect %s because $s cannot be harmed!\n
        /// </summary>
        Unknown179 = 0x000004F,
        
        /// <summary>
        /// You feel a harsh dissonance, and you sense that an act of killing you have committed recently is interfering with the conversion.\n
        /// </summary>
        Unknown180 = 0x000004F0,
        
        /// <summary>
        /// Bael'Zharon's power flows through you again. You are once more a player killer.\n
        /// </summary>
        Unknown181 = 0x000004F1,
        
        /// <summary>
        /// Bael'Zharon has granted you respite after your moment of weakness. You are temporarily no longer a player killer.\n
        /// </summary>
        Unknown182 = 0x000004F2,
        
        /// <summary>
        /// Lite Player Killers may not interact with that portal!\n
        /// </summary>
        Unknown183 = 0x000004F3,
        
        /// <summary>
        /// %s fails to affect you because $s cannot affect anyone!\n
        /// </summary>
        Unknown184 = 0x000004F4,
        
        /// <summary>
        /// %s fails to affect you because you cannot be harmed!\n
        /// </summary>
        Unknown185 = 0x000004F5,
        
        /// <summary>
        /// %s fails to affect you because %s is not a player killer!\n
        /// </summary>
        Unknown186 = 0x000004F6,
        
        /// <summary>
        ///  fails to affect you because you are not a player killer!\n
        /// </summary>
        Unknown187 = 0x000004F7,
        
        /// <summary>
        ///  fails to affect you because you are not the same sort of player killer as 
        /// </summary>
        Unknown188 = 0x000004F8,
        
        /// <summary>
        ///  fails to affect you across a house boundary!\n
        /// </summary>
        Unknown189 = 0x000004F9,
        
        /// <summary>
        ///  is an invalid target.\n
        /// </summary>
        Unknown190 = 0x000004FA,
        
        /// <summary>
        /// You are an invalid target for the spell of %s.\n
        /// </summary>
        Unknown191 = 0x000004FB,
        
        /// <summary>
        /// You aren't trained in healing!
        /// </summary>
        Unknown192 = 0x000004FC,
        
        /// <summary>
        /// You don't own that healing kit!
        /// </summary>
        Unknown193 = 0x000004FD,
        
        /// <summary>
        /// You can't heal that!
        /// </summary>
        Unknown194 = 0x000004FE,
        
        /// <summary>
        ///  is already at full health!
        /// </summary>
        Unknown195 = 0x000004FF,
        
        /// <summary>
        /// You fail to affect %s because beneficial spells do not affect %s!\n
        /// </summary>
        Unknown196 = 0x0000050,
        
        /// <summary>
        /// You aren't ready to heal!
        /// </summary>
        Unknown197 = 0x00000500,
        
        /// <summary>
        /// You can only use Healing Kits on player characters.
        /// </summary>
        Unknown198 = 0x00000501,
        
        /// <summary>
        /// The Lifestone's magic protects you from the attack!\n
        /// </summary>
        Unknown199 = 0x00000502,
        
        /// <summary>
        /// The portal's residual energy protects you from the attack!\n
        /// </summary>
        Unknown200 = 0x00000503,
        
        /// <summary>
        /// You are enveloped in a feeling of warmth as you are brought back into the protection of the Light. You are once again a Non-Player Killer.\n
        /// </summary>
        Unknown201 = 0x00000504,
        
        /// <summary>
        /// You're too close to your sanctuary!
        /// </summary>
        Unknown202 = 0x00000505,
        
        /// <summary>
        /// You can't do that -- you're trading!
        /// </summary>
        Unknown203 = 0x00000506,
        
        /// <summary>
        /// Only Non-Player Killers may enter PK Lite. Please see @help pklite for more details about this command.\n
        /// </summary>
        Unknown204 = 0x00000507,
        
        /// <summary>
        /// A cold wind touches your heart. You are now a Player Killer Lite.\n
        /// </summary>
        Unknown205 = 0x00000508,
        
        /// <summary>
        ///  has no appropriate targets equipped for this spell.\n
        /// </summary>
        Unknown206 = 0x00000509,
        
        /// <summary>
        /// You have no appropriate targets equipped for %s's spell.\n
        /// </summary>
        Unknown207 = 0x0000050A,
        
        /// <summary>
        ///  is now an open fellowship; anyone may recruit new members.\n
        /// </summary>
        Unknown208 = 0x0000050B,
        
        /// <summary>
        ///  is now a closed fellowship.\n
        /// </summary>
        Unknown209 = 0x0000050C,
        
        /// <summary>
        ///  is now the leader of this fellowship.\n
        /// </summary>
        Unknown210 = 0x0000050D,
        
        /// <summary>
        /// You have passed leadership of the fellowship to %s\n
        /// </summary>
        Unknown211 = 0x0000050E,
        
        /// <summary>
        /// You do not belong to a Fellowship.
        /// </summary>
        Unknown212 = 0x0000050F,
        
        /// <summary>
        /// You fail to affect %s because you are not a player killer!\n
        /// </summary>
        Unknown213 = 0x0000051,
        
        /// <summary>
        /// You may not hook any more %s on your house.  You already have the maximum number of %s hooked or you are not permitted to hook any on your type of house.\n
        /// </summary>
        Unknown214 = 0x00000510,
        
        /// <summary>
        /// You are now using the maximum number of hooks.  You cannot use another hook until you take an item off one of your hooks.\n
        /// </summary>
        Unknown215 = 0x00000512,
        
        /// <summary>
        /// You are no longer using the maximum number of hooks.  You may again add items to your hooks.\n
        /// </summary>
        Unknown216 = 0x00000513,
        
        /// <summary>
        /// You now have the maximum number of %s hooked.  You cannot hook any additional %s until you remove one or more from your house.\n
        /// </summary>
        Unknown217 = 0x00000514,
        
        /// <summary>
        /// You no longer have the maximum number of %s hooked.  You may hook additional %s.\n
        /// </summary>
        Unknown218 = 0x00000515,
        
        /// <summary>
        /// You are not permitted to use that hook.\n
        /// </summary>
        Unknown219 = 0x00000516,
        
        /// <summary>
        ///  is not close enough to your level.\n
        /// </summary>
        Unknown220 = 0x00000517,
        
        /// <summary>
        /// This fellowship is locked; %s cannot be recruited into the fellowship.\n
        /// </summary>
        Unknown221 = 0x00000518,
        
        /// <summary>
        /// The fellowship is locked, you were not added to the fellowship.\n
        /// </summary>
        Unknown222 = 0x00000519,
        
        /// <summary>
        /// Only the original owner may use that item's magic.
        /// </summary>
        Unknown223 = 0x0000051A,
        
        /// <summary>
        /// You have entered the %s channel.\n
        /// </summary>
        Unknown224 = 0x0000051B,
        
        /// <summary>
        /// You have left the %s channel.\n
        /// </summary>
        Unknown225 = 0x0000051C,
        
        /// <summary>
        ///  will not receive your message, please use urgent assistance to speak with an in-game representative\n
        /// </summary>
        Unknown226 = 0x0000051E,
        
        /// <summary>
        /// Message Blocked: %s
        /// </summary>
        Unknown227 = 0x0000051F,
        
        /// <summary>
        /// You fail to affect %s because %s is not a player killer!\n
        /// </summary>
        Unknown228 = 0x0000052,
        
        /// <summary>
        /// You cannot add anymore people to the list of players that you can hear.\n
        /// </summary>
        Unknown229 = 0x00000520,
        
        /// <summary>
        ///  has been added to the list of people you can hear.\n
        /// </summary>
        Unknown230 = 0x00000521,
        
        /// <summary>
        ///  has been removed from the list of people you can hear.\n
        /// </summary>
        Unknown231 = 0x00000522,
        
        /// <summary>
        /// You are now deaf to player's screams.\n
        /// </summary>
        Unknown232 = 0x00000523,
        
        /// <summary>
        /// You can hear all players once again.\n
        /// </summary>
        Unknown233 = 0x00000524,
        
        /// <summary>
        /// You fail to remove %s from your loud list.\n
        /// </summary>
        Unknown234 = 0x00000525,
        
        /// <summary>
        /// You chicken out.
        /// </summary>
        Unknown235 = 0x00000526,
        
        /// <summary>
        /// You cannot posssibly succeed.
        /// </summary>
        Unknown236 = 0x00000527,
        
        /// <summary>
        /// The fellowship is locked; you cannot open locked fellowships.\n
        /// </summary>
        Unknown237 = 0x00000528,
        
        /// <summary>
        /// Trade Complete!
        /// </summary>
        Unknown238 = 0x00000529,
        
        /// <summary>
        /// That is not a salvaging tool.
        /// </summary>
        Unknown239 = 0x0000052A,
        
        /// <summary>
        /// That person is not available now.
        /// </summary>
        Unknown240 = 0x0000052B,
        
        /// <summary>
        /// You are now snooping on %s.\n
        /// </summary>
        Unknown241 = 0x0000052C,
        
        /// <summary>
        /// You are no longer snooping on %s.\n
        /// </summary>
        Unknown242 = 0x0000052D,
        
        /// <summary>
        /// You fail to snoop on %s.\n
        /// </summary>
        Unknown243 = 0x0000052E,
        
        /// <summary>
        /// %s attempted to snoop on you.\n
        /// </summary>
        Unknown244 = 0x0000052F,
        
        /// <summary>
        /// You fail to affect %s because you are not the same sort of player killer as %s!\n
        /// </summary>
        Unknown245 = 0x0000053,
        
        /// <summary>
        /// %s is already being snooped on, only one person may snoop on another at a time.\n
        /// </summary>
        Unknown246 = 0x00000530,
        
        /// <summary>
        /// %s is in limbo and cannot receive your message.\n
        /// </summary>
        Unknown247 = 0x00000531,
        
        /// <summary>
        /// You must wait 30 days after purchasing a house before you may purchase another with any character on the same account. This applies to all housing except apartments.\n
        /// </summary>
        Unknown248 = 0x00000532,
        
        /// <summary>
        /// You have been booted from your allegiance chat room. Use "@allegiance chat on" to rejoin. (%s).\n
        /// </summary>
        Unknown249 = 0x00000533,
        
        /// <summary>
        /// %s has been booted from the allegiance chat room.\n
        /// </summary>
        Unknown250 = 0x00000534,
        
        /// <summary>
        /// You do not have the authority within your allegiance to do that.\n
        /// </summary>
        Unknown251 = 0x00000535,
        
        /// <summary>
        /// The account of %s is already banned from the allegiance.\n
        /// </summary>
        Unknown252 = 0x00000536,
        
        /// <summary>
        /// The account of %s is not banned from the allegiance.\n
        /// </summary>
        Unknown253 = 0x00000537,
        
        /// <summary>
        /// The account of %s was not unbanned from the allegiance.\n
        /// </summary>
        Unknown254 = 0x00000538,
        
        /// <summary>
        /// The account of %s has been banned from the allegiance.\n
        /// </summary>
        Unknown255 = 0x00000539,
        
        /// <summary>
        /// The account of %s is no longer banned from the allegiance.\n
        /// </summary>
        Unknown256 = 0x0000053A,
        
        /// <summary>
        /// Banned Characters: 
        /// </summary>
        Unknown257 = 0x0000053B,
        
        /// <summary>
        /// %s is banned from the allegiance!\n
        /// </summary>
        Unknown258 = 0x0000053E,
        
        /// <summary>
        /// You are banned from %s's allegiance!\n
        /// </summary>
        Unknown259 = 0x0000053F,
        
        /// <summary>
        /// You fail to affect %s because you are acting across a house boundary!\n
        /// </summary>
        Unknown260 = 0x0000054,
        
        /// <summary>
        /// You have the maximum number of accounts banned.!\n
        /// </summary>
        Unknown261 = 0x00000540,
        
        /// <summary>
        /// %s is now an allegiance officer.\n
        /// </summary>
        Unknown262 = 0x00000541,
        
        /// <summary>
        /// An unspecified error occurred while attempting to set %s as an allegiance officer.\n
        /// </summary>
        Unknown263 = 0x00000542,
        
        /// <summary>
        /// %s is no longer an allegiance officer.\n
        /// </summary>
        Unknown264 = 0x00000543,
        
        /// <summary>
        /// An unspecified error occurred while attempting to remove %s as an allegiance officer.\n
        /// </summary>
        Unknown265 = 0x00000544,
        
        /// <summary>
        /// You already have the maximum number of allegiance officers. You must remove some before you add any more.\n
        /// </summary>
        Unknown266 = 0x00000545,
        
        /// <summary>
        /// Your allegiance officers have been cleared.\n
        /// </summary>
        Unknown267 = 0x00000546,
        
        /// <summary>
        /// You must wait %s before communicating again!\n
        /// </summary>
        Unknown268 = 0x00000547,
        
        /// <summary>
        /// You cannot join any chat channels while gagged.\n
        /// </summary>
        Unknown269 = 0x00000548,
        
        /// <summary>
        /// Your allegiance officer status has been modified. You now hold the position of: %s.\n
        /// </summary>
        Unknown270 = 0x00000549,
        
        /// <summary>
        /// You are no longer an allegiance officer.\n
        /// </summary>
        Unknown271 = 0x0000054A,
        
        /// <summary>
        /// %s is already an allegiance officer of that level.\n
        /// </summary>
        Unknown272 = 0x0000054B,
        
        /// <summary>
        /// Your allegiance does not have a hometown.\n
        /// </summary>
        Unknown273 = 0x0000054C,
        
        /// <summary>
        /// The %s is currently in use.\n
        /// </summary>
        Unknown274 = 0x0000054D,
        
        /// <summary>
        /// The hook does not contain a usable item. You cannot open the hook because you do not own the house to which it belongs.\n
        /// </summary>
        Unknown275 = 0x0000054E,
        
        /// <summary>
        /// The hook does not contain a usable item. Use the '@house hooks on'command to make the hook openable.\n
        /// </summary>
        Unknown276 = 0x0000054F,
        
        /// <summary>
        /// Out of Range!
        /// </summary>
        Unknown277 = 0x00000550,
        
        /// <summary>
        /// You are not listening to the %s channel!\n
        /// </summary>
        Unknown278 = 0x00000551,
        
        /// <summary>
        /// You must purchase Asheron's Call -- Throne of Destiny to use this function.
        /// </summary>
        Unknown279 = 0x00000552,
        
        /// <summary>
        /// You must purchase Asheron's Call -- Throne of Destiny to use this item.
        /// </summary>
        Unknown280 = 0x00000553,
        
        /// <summary>
        /// You must purchase Asheron's Call -- Throne of Destiny to use this portal.
        /// </summary>
        Unknown281 = 0x00000554,
        
        /// <summary>
        /// You must purchase Asheron's Call -- Throne of Destiny to access this quest.
        /// </summary>
        Unknown282 = 0x00000555,
        
        /// <summary>
        /// You have failed to complete the augmentation.\n
        /// </summary>
        Unknown283 = 0x00000556,
        
        /// <summary>
        /// You have used this augmentation too many times already.\n
        /// </summary>
        Unknown284 = 0x00000557,
        
        /// <summary>
        /// You have used augmentations of this type too many times already.\n
        /// </summary>
        Unknown285 = 0x00000558,
        
        /// <summary>
        /// You do not have enough unspent experience available to purchase this augmentation.\n
        /// </summary>
        Unknown286 = 0x00000559,
        
        /// <summary>
        /// %s\n
        /// </summary>
        Unknown287 = 0x0000055A,
        
        /// <summary>
        /// Congratulations! You have succeeded in acquiring the %s augmentation.\n
        /// </summary>
        Unknown288 = 0x0000055B,
        
        /// <summary>
        /// Although your augmentation will not allow you to untrain your %s skill, you have succeeded in recovering all the experience you had invested in it.\n
        /// </summary>
        Unknown289 = 0x0000055C,
        
        /// <summary>
        /// You must exit the Training Academy before that command will be available to you.\n
        /// </summary>
        Unknown290 = 0x0000055D,
        
        /// <summary>
        /// {arbitrary string sent by server}
        /// </summary>
        Unknown291 = 0x0000055E,
        
        /// <summary>
        /// Only Player Killer characters may use this command!\n
        /// </summary>
        Unknown292 = 0x0000055F,
        
        /// <summary>
        /// Only Player Killer Lite characters may use this command!\n
        /// </summary>
        Unknown293 = 0x00000560,
        
        /// <summary>
        /// You may only have a maximum of 50 friends at once. If you wish to add more friends, you must first remove some.
        /// </summary>
        Unknown294 = 0x00000561,
        
        /// <summary>
        /// %s is already on your friends list!\n
        /// </summary>
        Unknown295 = 0x00000562,
        
        /// <summary>
        /// That character is not on your friends list!\n
        /// </summary>
        Unknown296 = 0x00000563,
        
        /// <summary>
        /// Only the character who owns the house may use this command.
        /// </summary>
        Unknown297 = 0x00000564,
        
        /// <summary>
        /// That allegiance name is invalid because it is empty. Please use the @allegiance name clear command to clear your allegiance name.\n
        /// </summary>
        Unknown298 = 0x00000565,
        
        /// <summary>
        /// That allegiance name is too long. Please choose another name.\n
        /// </summary>
        Unknown299 = 0x00000566,
        
        /// <summary>
        /// That allegiance name contains illegal characters. Please choose another name using only letters, spaces, - and '.\n
        /// </summary>
        Unknown300 = 0x00000567,
        
        /// <summary>
        /// That allegiance name is not appropriate. Please choose another name.\n
        /// </summary>
        Unknown301 = 0x00000568,
        
        /// <summary>
        /// That allegiance name is already in use. Please choose another name.\n
        /// </summary>
        Unknown302 = 0x00000569,
        
        /// <summary>
        /// You may only change your allegiance name once every 24 hours. You may change your allegiance name again in %s.\n
        /// </summary>
        Unknown303 = 0x0000056A,
        
        /// <summary>
        /// Your allegiance name has been cleared.\n
        /// </summary>
        Unknown304 = 0x0000056B,
        
        /// <summary>
        /// That is already the name of your allegiance!\n
        /// </summary>
        Unknown305 = 0x0000056C,
        
        /// <summary>
        /// %s is the monarch and cannot be promoted or demoted.\n
        /// </summary>
        Unknown306 = 0x0000056D,
        
        /// <summary>
        /// That level of allegiance officer is now known as: %s.\n
        /// </summary>
        Unknown307 = 0x0000056E,
        
        /// <summary>
        /// That is an invalid officer level.\n
        /// </summary>
        Unknown308 = 0x0000056F,
        
        /// <summary>
        /// That allegiance officer title is not appropriate.\n
        /// </summary>
        Unknown309 = 0x00000570,
        
        /// <summary>
        /// That allegiance name is too long. Please choose another name.\n
        /// </summary>
        Unknown310 = 0x00000571,
        
        /// <summary>
        /// All of your allegiance officer titles have been cleared.\n
        /// </summary>
        Unknown311 = 0x00000572,
        
        /// <summary>
        /// That allegiance title contains illegal characters. Please choose another name using only letters, spaces, - and '.\n
        /// </summary>
        Unknown312 = 0x00000573,
        
        /// <summary>
        /// Your allegiance is currently: %s.\n
        /// </summary>
        Unknown313 = 0x00000574,
        
        /// <summary>
        /// Your allegiance is now: %s.\n
        /// </summary>
        Unknown314 = 0x00000575,
        
        /// <summary>
        /// You may not accept the offer of allegiance from %s because your allegiance is locked.\n
        /// </summary>
        Unknown315 = 0x00000576,
        
        /// <summary>
        /// You may not swear allegiance at this time because the allegiance of %s is locked.\n
        /// </summary>
        Unknown316 = 0x00000577,
        
        /// <summary>
        /// You have pre-approved %s to join your allegiance.\n
        /// </summary>
        Unknown317 = 0x00000578,
        
        /// <summary>
        /// You have not pre-approved any vassals to join your allegiance.\n
        /// </summary>
        Unknown318 = 0x00000579,
        
        /// <summary>
        /// %s is already a member of your allegiance!\n
        /// </summary>
        Unknown319 = 0x0000057A,
        
        /// <summary>
        /// %s has been pre-approved to join your allegiance.\n
        /// </summary>
        Unknown320 = 0x0000057B,
        
        /// <summary>
        /// You have cleared the pre-approved vassal for your allegiance.\n
        /// </summary>
        Unknown321 = 0x0000057C,
        
        /// <summary>
        /// That character is already gagged!\n
        /// </summary>
        Unknown322 = 0x0000057D,
        
        /// <summary>
        /// That character is not currently gagged!\n
        /// </summary>
        Unknown323 = 0x0000057E,
        
        /// <summary>
        /// Your allegiance chat privileges have been temporarily removed by %s. Until they are restored, you may not view or speak in the allegiance chat channel.
        /// </summary>
        Unknown324 = 0x0000057F,
        
        /// <summary>
        /// %s is now temporarily unable to view or speak in allegiance chat. The gag will run out in 5 minutes, or %s may be explicitly ungagged before then.
        /// </summary>
        Unknown325 = 0x00000580,
        
        /// <summary>
        /// Your allegiance chat privileges have been restored.\n
        /// </summary>
        Unknown326 = 0x00000581,
        
        /// <summary>
        /// Your allegiance chat privileges have been restored by %s.
        /// </summary>
        Unknown327 = 0x00000582,
        
        /// <summary>
        /// You have restored allegiance chat privileges to %s.
        /// </summary>
        Unknown328 = 0x00000583,
        
        /// <summary>
        /// You cannot pick up more of that item!
        /// </summary>
        Unknown329 = 0x00000584,
        
        /// <summary>
        /// You are restricted to clothes and armor created for your race.
        /// </summary>
        Unknown330 = 0x00000585,
        
        /// <summary>
        /// That item was specifically created for another race.
        /// </summary>
        Unknown331 = 0x00000586,
        
        /// <summary>
        /// Olthoi cannot interact with that!\n
        /// </summary>
        Unknown332 = 0x00000587,
        
        /// <summary>
        /// Olthoi cannot use regular lifestones! Asheron would not allow it!\n
        /// </summary>
        Unknown333 = 0x00000588,
        
        /// <summary>
        /// The vendor looks at you in horror!\n
        /// </summary>
        Unknown334 = 0x00000589,
        
        /// <summary>
        /// %s cowers from you!\n
        /// </summary>
        Unknown335 = 0x0000058A,
        
        /// <summary>
        /// As a mindless engine of destruction an Olthoi cannot join a fellowship!\n
        /// </summary>
        Unknown336 = 0x0000058B,
        
        /// <summary>
        /// The Olthoi only have an allegiance to the Olthoi Queen!\n
        /// </summary>
        Unknown337 = 0x0000058C,
        
        /// <summary>
        /// You cannot use that item!\n
        /// </summary>
        Unknown338 = 0x0000058D,
        
        /// <summary>
        /// This person will not interact with you!\n
        /// </summary>
        Unknown339 = 0x0000058E,
        
        /// <summary>
        /// Only Olthoi may pass through this portal!\n
        /// </summary>
        Unknown340 = 0x0000058F,
        
        /// <summary>
        /// Olthoi may not pass through this portal!\n
        /// </summary>
        Unknown341 = 0x00000590,
        
        /// <summary>
        /// You may not pass through this portal while Vitae weakens you!\n
        /// </summary>
        Unknown342 = 0x00000591,
        
        /// <summary>
        /// This character must be two weeks old or have been created on an account at least two weeks old to use this portal!\n
        /// </summary>
        Unknown343 = 0x00000592,
        
        /// <summary>
        /// Olthoi characters can only use Lifestone and PK Arena recalls!\n
        /// </summary>
        Unknown344 = 0x00000593
    }
}
