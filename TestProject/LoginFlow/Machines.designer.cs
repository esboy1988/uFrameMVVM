// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Invert.MVVMTest {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.StateMachine;
    
    
    public class LoginFlow : Invert.StateMachine.StateMachine {
        
        private Invert.StateMachine.StateMachineTrigger _MiniCamp;
        
        private Invert.StateMachine.StateMachineTrigger _DailyWorkout;
        
        private Invert.StateMachine.StateMachineTrigger _BeginLogin;
        
        private LoginState _LoginState;
        
        private LandingPageState _LandingPageState;
        
        private BeginState _BeginState;
        
        public LoginFlow(ViewModel vm, string propertyName) : 
                base(vm, propertyName) {
        }
        
        public override Invert.StateMachine.State StartState {
            get {
                return this.BeginState;
            }
        }
        
        public virtual Invert.StateMachine.StateMachineTrigger MiniCamp {
            get {
                if (this._MiniCamp == null) {
                    this._MiniCamp = new StateMachineTrigger(this , "MiniCamp");
                }
                return _MiniCamp;
            }
            set {
                _MiniCamp = value;
            }
        }
        
        public virtual Invert.StateMachine.StateMachineTrigger DailyWorkout {
            get {
                if (this._DailyWorkout == null) {
                    this._DailyWorkout = new StateMachineTrigger(this , "DailyWorkout");
                }
                return _DailyWorkout;
            }
            set {
                _DailyWorkout = value;
            }
        }
        
        public virtual Invert.StateMachine.StateMachineTrigger BeginLogin {
            get {
                if (this._BeginLogin == null) {
                    this._BeginLogin = new StateMachineTrigger(this , "BeginLogin");
                }
                return _BeginLogin;
            }
            set {
                _BeginLogin = value;
            }
        }
        
        public virtual LoginState LoginState {
            get {
                if (this._LoginState == null) {
                    this._LoginState = new LoginState();
                }
                return _LoginState;
            }
            set {
                _LoginState = value;
            }
        }
        
        public virtual LandingPageState LandingPageState {
            get {
                if (this._LandingPageState == null) {
                    this._LandingPageState = new LandingPageState();
                }
                return _LandingPageState;
            }
            set {
                _LandingPageState = value;
            }
        }
        
        public virtual BeginState BeginState {
            get {
                if (this._BeginState == null) {
                    this._BeginState = new BeginState();
                }
                return _BeginState;
            }
            set {
                _BeginState = value;
            }
        }
        
        public override void Compose(System.Collections.Generic.List<Invert.StateMachine.State> states) {
            base.Compose(states);
            LoginState.DailyWorkout = new StateTransition("DailyWorkout", LoginState, LandingPageState);
            Transitions.Add(LoginState.DailyWorkout);
            LoginState.AddTrigger(DailyWorkout, LoginState.DailyWorkout);
            LoginState.StateMachine = this;
            states.Add(LoginState);
            LandingPageState.StateMachine = this;
            states.Add(LandingPageState);
            BeginState.BeginLogin = new StateTransition("BeginLogin", BeginState, LoginState);
            Transitions.Add(BeginState.BeginLogin);
            BeginState.AddTrigger(BeginLogin, BeginState.BeginLogin);
            BeginState.StateMachine = this;
            states.Add(BeginState);
        }
    }
    
    public class LoginState : Invert.StateMachine.State {
        
        private Invert.StateMachine.StateTransition _DailyWorkout;
        
        public Invert.StateMachine.StateTransition DailyWorkout {
            get {
                return _DailyWorkout;
            }
            set {
                _DailyWorkout = value;
            }
        }
        
        public override string Name {
            get {
                return "LoginState";
            }
        }
        
        public virtual void DailyWorkoutTransition() {
            this.Transition(this.DailyWorkout);
        }
    }
    
    public class LandingPageState : Invert.StateMachine.State {
        
        public override string Name {
            get {
                return "LandingPageState";
            }
        }
    }
    
    public class BeginState : Invert.StateMachine.State {
        
        private Invert.StateMachine.StateTransition _BeginLogin;
        
        public Invert.StateMachine.StateTransition BeginLogin {
            get {
                return _BeginLogin;
            }
            set {
                _BeginLogin = value;
            }
        }
        
        public override string Name {
            get {
                return "BeginState";
            }
        }
        
        public virtual void BeginLoginTransition() {
            this.Transition(this.BeginLogin);
        }
    }
}
