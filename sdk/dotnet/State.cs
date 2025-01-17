// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools
{
    [CommercetoolsResourceType("commercetools:index/state:State")]
    public partial class State : Pulumi.CustomResource
    {
        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        [Output("description")]
        public Output<ImmutableDictionary<string, object>?> Description { get; private set; } = null!;

        /// <summary>
        /// A state can be declared as an initial state for any state machine. When a workflow starts, this first state must be an
        /// initial state
        /// </summary>
        [Output("initial")]
        public Output<bool?> Initial { get; private set; } = null!;

        /// <summary>
        /// A unique identifier for the state
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        [Output("name")]
        public Output<ImmutableDictionary<string, object>> Name { get; private set; } = null!;

        /// <summary>
        /// Array of [State Role](https://docs.commercetools.com/api/projects/states#staterole)
        /// </summary>
        [Output("roles")]
        public Output<ImmutableArray<string>> Roles { get; private set; } = null!;

        /// <summary>
        /// Transitions are a way to describe possible transformations of the current state to other states of the same type (for
        /// example: Initial -&gt; Shipped). When performing a transitionState update action and transitions is set, the currently
        /// referenced state must have a transition to the new state. If transitions is an empty list, it means the current state is
        /// a final state and no further transitions are allowed. If transitions is not set, the validation is turned off. When
        /// performing a transitionState update action, any other state of the same type can be transitioned to
        /// </summary>
        [Output("transitions")]
        public Output<ImmutableArray<string>> Transitions { get; private set; } = null!;

        /// <summary>
        /// [StateType](https://docs.commercetools.com/api/projects/states#statetype)
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a State resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public State(string name, StateArgs args, CustomResourceOptions? options = null)
            : base("commercetools:index/state:State", name, args ?? new StateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private State(string name, Input<string> id, StateState? state = null, CustomResourceOptions? options = null)
            : base("commercetools:index/state:State", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing State resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static State Get(string name, Input<string> id, StateState? state = null, CustomResourceOptions? options = null)
        {
            return new State(name, id, state, options);
        }
    }

    public sealed class StateArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        private InputMap<object>? _description;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Description
        {
            get => _description ?? (_description = new InputMap<object>());
            set => _description = value;
        }

        /// <summary>
        /// A state can be declared as an initial state for any state machine. When a workflow starts, this first state must be an
        /// initial state
        /// </summary>
        [Input("initial")]
        public Input<bool>? Initial { get; set; }

        /// <summary>
        /// A unique identifier for the state
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("name")]
        private InputMap<object>? _name;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// Array of [State Role](https://docs.commercetools.com/api/projects/states#staterole)
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        [Input("transitions")]
        private InputList<string>? _transitions;

        /// <summary>
        /// Transitions are a way to describe possible transformations of the current state to other states of the same type (for
        /// example: Initial -&gt; Shipped). When performing a transitionState update action and transitions is set, the currently
        /// referenced state must have a transition to the new state. If transitions is an empty list, it means the current state is
        /// a final state and no further transitions are allowed. If transitions is not set, the validation is turned off. When
        /// performing a transitionState update action, any other state of the same type can be transitioned to
        /// </summary>
        public InputList<string> Transitions
        {
            get => _transitions ?? (_transitions = new InputList<string>());
            set => _transitions = value;
        }

        /// <summary>
        /// [StateType](https://docs.commercetools.com/api/projects/states#statetype)
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public StateArgs()
        {
        }
    }

    public sealed class StateState : Pulumi.ResourceArgs
    {
        [Input("description")]
        private InputMap<object>? _description;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Description
        {
            get => _description ?? (_description = new InputMap<object>());
            set => _description = value;
        }

        /// <summary>
        /// A state can be declared as an initial state for any state machine. When a workflow starts, this first state must be an
        /// initial state
        /// </summary>
        [Input("initial")]
        public Input<bool>? Initial { get; set; }

        /// <summary>
        /// A unique identifier for the state
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("name")]
        private InputMap<object>? _name;

        /// <summary>
        /// [LocalizedString](https://docs.commercetools.com/api/types#localizedstring)
        /// </summary>
        public InputMap<object> Name
        {
            get => _name ?? (_name = new InputMap<object>());
            set => _name = value;
        }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// Array of [State Role](https://docs.commercetools.com/api/projects/states#staterole)
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        [Input("transitions")]
        private InputList<string>? _transitions;

        /// <summary>
        /// Transitions are a way to describe possible transformations of the current state to other states of the same type (for
        /// example: Initial -&gt; Shipped). When performing a transitionState update action and transitions is set, the currently
        /// referenced state must have a transition to the new state. If transitions is an empty list, it means the current state is
        /// a final state and no further transitions are allowed. If transitions is not set, the validation is turned off. When
        /// performing a transitionState update action, any other state of the same type can be transitioned to
        /// </summary>
        public InputList<string> Transitions
        {
            get => _transitions ?? (_transitions = new InputList<string>());
            set => _transitions = value;
        }

        /// <summary>
        /// [StateType](https://docs.commercetools.com/api/projects/states#statetype)
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("version")]
        public Input<int>? Version { get; set; }

        public StateState()
        {
        }
    }
}
