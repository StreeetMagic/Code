//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDraft;

    public static Entitas.IMatcher<GameEntity> Draft {
        get {
            if (_matcherDraft == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Draft);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDraft = matcher;
            }

            return _matcherDraft;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.Alchemy.Draft draft { get { return (Code.Gameplay.Features.Alchemy.Draft)GetComponent(GameComponentsLookup.Draft); } }
    public System.Collections.Generic.Dictionary<Code.Gameplay.Features.Items.ItemId, int> Draft { get { return draft.Value; } }
    public bool hasDraft { get { return HasComponent(GameComponentsLookup.Draft); } }

    public GameEntity AddDraft(System.Collections.Generic.Dictionary<Code.Gameplay.Features.Items.ItemId, int> newValue) {
        var index = GameComponentsLookup.Draft;
        var component = (Code.Gameplay.Features.Alchemy.Draft)CreateComponent(index, typeof(Code.Gameplay.Features.Alchemy.Draft));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceDraft(System.Collections.Generic.Dictionary<Code.Gameplay.Features.Items.ItemId, int> newValue) {
        var index = GameComponentsLookup.Draft;
        var component = (Code.Gameplay.Features.Alchemy.Draft)CreateComponent(index, typeof(Code.Gameplay.Features.Alchemy.Draft));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveDraft() {
        RemoveComponent(GameComponentsLookup.Draft);
        return this;
    }
}
