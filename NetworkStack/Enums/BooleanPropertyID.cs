////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The BooleanPropertyID identifies a specific Character or Object boolean property.
    /// </summary>
    public enum BooleanPropertyID : uint
    {
        Undef = 0x00000000,
        Stuck = 0x00000001,
        Open = 0x00000002,
        Locked = 0x00000003,
        RotProof = 0x00000004,
        AllegianceUpdateRequest = 0x00000005,
        AiUsesMana = 0x00000006,
        AiUseHumanMagicAnimations = 0x00000007,
        AllowGive = 0x00000008,
        CurrentlyAttacking = 0x00000009,
        AttackerAi = 0x0000000A,
        IgnoreCollisions = 0x0000000B,
        ReportCollisions = 0x0000000C,
        Ethereal = 0x0000000D,
        GravityStatus = 0x0000000E,
        LightsStatus = 0x0000000F,
        ScriptedCollision = 0x00000010,
        Inelastic = 0x00000011,
        Visibility = 0x00000012,
        Attackable = 0x00000013,
        SafeSpellComponents = 0x00000014,
        AdvocateState = 0x00000015,
        Inscribable = 0x00000016,
        DestroyOnSell = 0x00000017,
        UiHidden = 0x00000018,
        IgnoreHouseBarriers = 0x00000019,
        HiddenAdmin = 0x0000001A,
        PkWounder = 0x0000001B,
        PkKiller = 0x0000001C,
        NoCorpse = 0x0000001D,
        UnderLifestoneProtection = 0x0000001E,
        ItemManaUpdatePending = 0x0000001F,
        GeneratorStatus = 0x00000020,
        ResetMessagePending = 0x00000021,
        DefaultOpen = 0x00000022,
        DefaultLocked = 0x00000023,
        DefaultOn = 0x00000024,
        OpenForBusiness = 0x00000025,
        IsFrozen = 0x00000026,
        DealMagicalItems = 0x00000027,
        LogoffImDead = 0x00000028,
        ReportCollisionsAsEnvironment = 0x00000029,
        AllowEdgeSlide = 0x0000002A,
        AdvocateQuest = 0x0000002B,
        IsAdmin = 0x0000002C,
        IsArch = 0x0000002D,
        IsSentinel = 0x0000002E,
        IsAdvocate = 0x0000002F,
        CurrentlyPoweringUp = 0x00000030,
        GeneratorEnteredWorld = 0x00000031,
        NeverFailCasting = 0x00000032,
        VendorService = 0x00000033,
        AiImmobile = 0x00000034,
        DamagedByCollisions = 0x00000035,
        IsDynamic = 0x00000036,
        IsHot = 0x00000037,
        IsAffecting = 0x00000038,
        AffectsAis = 0x00000039,
        SpellQueueActive = 0x0000003A,
        GeneratorDisabled = 0x0000003B,
        IsAcceptingTells = 0x0000003C,
        LoggingChannel = 0x0000003D,
        OpensAnyLock = 0x0000003E,
        UnlimitedUse = 0x0000003F,
        GeneratedTreasureItem = 0x00000040,
        IgnoreMagicResist = 0x00000041,
        IgnoreMagicArmor = 0x00000042,
        AiAllowTrade = 0x00000043,
        SpellComponentsRequired = 0x00000044,
        IsSellable = 0x00000045,
        IgnoreShieldsBySkill = 0x00000046,
        NoDraw = 0x00000047,
        ActivationUntargeted = 0x00000048,
        HouseHasGottenPriorityBootPos = 0x00000049,
        GeneratorAutomaticDestruction = 0x0000004A,
        HouseHooksVisible = 0x0000004B,
        HouseRequiresMonarch = 0x0000004C,
        HouseHooksEnabled = 0x0000004D,
        HouseNotifiedHudOfHookCount = 0x0000004E,
        AiAcceptEverything = 0x0000004F,
        IgnorePortalRestrictions = 0x00000050,
        RequiresBackpackSlot = 0x00000051,
        DontTurnOrMoveWhenGiving = 0x00000052,
        NpcLooksLikeObject = 0x00000053,
        IgnoreCloIcons = 0x00000054,
        AppraisalHasAllowedWielder = 0x00000055,
        ChestRegenOnClose = 0x00000056,
        LogoffInMinigame = 0x00000057,
        PortalShowDestination = 0x00000058,
        PortalIgnoresPkAttackTimer = 0x00000059,
        NpcInteractsSilently = 0x0000005A,
        Retained = 0x0000005B,
        IgnoreAuthor = 0x0000005C,
        Limbo = 0x0000005D,
        AppraisalHasAllowedActivator = 0x0000005E,
        ExistedBeforeAllegianceXpChanges = 0x0000005F,
        IsDeaf = 0x00000060,
        IsPsr = 0x00000061,
        Invincible = 0x00000062,
        Ivoryable = 0x00000063,
        Dyable = 0x00000064,
        CanGenerateRare = 0x00000065,
        CorpseGeneratedRare = 0x00000066,
        NonProjectileMagicImmune = 0x00000067,
        ActdReceivedItems = 0x00000068,
        Unknown105 = 0x00000069,
        FirstEnterWorldDone = 0x0000006A,
        RecallsDisabled = 0x0000006B,
        RareUsesTimer = 0x0000006C,
        ActdPreorderReceivedItems = 0x0000006D,
        Afk = 0x0000006E,
        IsGagged = 0x0000006F,
        ProcSpellSelfTargeted = 0x00000070,
        IsAllegianceGagged = 0x00000071,
        EquipmentSetTriggerPiece = 0x00000072,
        Uninscribe = 0x00000073,
        WieldOnUse = 0x00000074,
        ChestClearedWhenClosed = 0x00000075,
        NeverAttack = 0x00000076,
        SuppressGenerateEffect = 0x00000077,
        TreasureCorpse = 0x00000078,
        EquipmentSetAddLevel = 0x00000079,
        BarberActive = 0x0000007A,
        TopLayerPriority = 0x0000007B,
        NoHeldItemShown = 0x0000007C,
        LoginAtLifestone = 0x0000007D,
        OlthoiPk = 0x0000007E,
        Account15Days = 0x0000007F,
        HadNoVitae = 0x00000080,
        NoOlthoiTalk = 0x00000081,
        AutowieldLeft = 0x00000082
    }
}