using Command.CommandImplementations;
using Command.Devices;
using Command.Devices.States;
using NUnit.Framework;

namespace Command.Test
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void SimpleRemoteControlTest()
        {
            var simpleRemote = new SimpleRemoteControl();
            var light = new Light();
            Assert.AreEqual(LightState.Off, light.LightState);

            var lightOnCommand = new LightOnCommand(light);
            simpleRemote.SetCommand(lightOnCommand);
            simpleRemote.ButtonWasPressed();
            Assert.AreEqual(LightState.On, light.LightState);

            var garageDoor = new GarageDoor();
            Assert.AreEqual(GarageDoorState.Stopped, garageDoor.GarageDoorState);

            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            simpleRemote.SetCommand(garageDoorOpenCommand);
            simpleRemote.ButtonWasPressed();
            Assert.AreEqual(GarageDoorState.MoveUp, garageDoor.GarageDoorState);
        }

        [Test]
        public void RemoteControlTest()
        {
            var remoteControl = new RemoteControl();

            var kitchenLight = new Light();
            var hallLight = new Light();
            var livingRoomLight = new Light();
            var garageDoor = new GarageDoor();

            var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            var hallLightOnCommand = new LightOnCommand(hallLight);
            var hallLightOffCommand = new LightOffCommand(hallLight);

            var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);

            var garageDoorLightOnCommand = new GarageDoorLightOnCommand(garageDoor);
            var garageDoorLightOffCommand = new GarageDoorLightOffCommand(garageDoor);

            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            remoteControl.SetCommands(0, kitchenLightOnCommand, kitchenLightOffCommand);
            remoteControl.SetCommands(1, hallLightOnCommand, hallLightOffCommand);
            remoteControl.SetCommands(2, livingRoomLightOnCommand, livingRoomLightOffCommand);
            remoteControl.SetCommands(3, garageDoorLightOnCommand, garageDoorLightOffCommand);
            remoteControl.SetCommands(4, garageDoorOpenCommand, garageDoorCloseCommand);


            remoteControl.OnButtonWasPushed(0);
            Assert.AreEqual(LightState.On, kitchenLight.LightState);
            remoteControl.OffButtonWasPushed(0);
            Assert.AreEqual(LightState.Off, kitchenLight.LightState);

            remoteControl.OnButtonWasPushed(4);
            Assert.AreEqual(GarageDoorState.MoveUp, garageDoor.GarageDoorState);
            remoteControl.OffButtonWasPushed(4);
            Assert.AreEqual(GarageDoorState.MoveDown, garageDoor.GarageDoorState);

            remoteControl.OnButtonWasPushed(6);
            //no Exception
        }


        [Test]
        public void RemoteControlUndoTwoStatesTest()
        {
            var remoteControl = new RemoteControl();
            var kitchenLight = new Light();
            var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            remoteControl.SetCommands(0, kitchenLightOnCommand, kitchenLightOffCommand);

            remoteControl.OnButtonWasPushed(0);
            Assert.AreEqual(LightState.On, kitchenLight.LightState);
            remoteControl.OffButtonWasPushed(0);
            Assert.AreEqual(LightState.Off, kitchenLight.LightState);
            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(LightState.On, kitchenLight.LightState);
            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(LightState.On, kitchenLight.LightState);

            remoteControl.OnButtonWasPushed(0);
            Assert.AreEqual(LightState.On, kitchenLight.LightState);
            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(LightState.Off, kitchenLight.LightState);
        }

        [Test]
        public void RemoteControlUndoThreeStatesTest()
        {
            var remoteControl = new RemoteControl();
            var garageDoor = new GarageDoor();

            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            remoteControl.SetCommands(0, garageDoorOpenCommand, garageDoorCloseCommand);

            Assert.AreEqual(GarageDoorState.Stopped, garageDoor.GarageDoorState);

            remoteControl.OnButtonWasPushed(0);
            Assert.AreEqual(GarageDoorState.MoveUp, garageDoor.GarageDoorState);

            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(GarageDoorState.Stopped, garageDoor.GarageDoorState);

            remoteControl.OffButtonWasPushed(0);
            Assert.AreEqual(GarageDoorState.MoveDown, garageDoor.GarageDoorState);

            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(GarageDoorState.Stopped, garageDoor.GarageDoorState);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(GarageDoorState.MoveUp, garageDoor.GarageDoorState);
        }


        [Test]
        public void RemoteControlToggleLightsTest()
        {
            var remoteControl = new RemoteControl();

            var kitchenLight = new Light();
            var hallLight = new Light();
            var livingRoomLight = new Light();
            var garageDoor = new GarageDoor();

            var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            var hallLightOnCommand = new LightOnCommand(hallLight);
            var hallLightOffCommand = new LightOffCommand(hallLight);

            var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);

            var garageDoorLightOnCommand = new GarageDoorLightOnCommand(garageDoor);
            var garageDoorLightOffCommand = new GarageDoorLightOffCommand(garageDoor);

            var allLightsOnCommand = new MacroCommand(new ICommand[] 
             { kitchenLightOnCommand, hallLightOnCommand, livingRoomLightOnCommand, garageDoorLightOnCommand });

            var allLightsOffCommand = new MacroCommand(new ICommand[]
                { kitchenLightOffCommand, hallLightOffCommand, livingRoomLightOffCommand, garageDoorLightOffCommand });

            remoteControl.SetCommands(0, allLightsOnCommand, allLightsOffCommand);

            remoteControl.OnButtonWasPushed(0);
            Assert.AreEqual(LightState.On, kitchenLight.LightState);
            Assert.AreEqual(LightState.On, hallLight.LightState);
            Assert.AreEqual(LightState.On, livingRoomLight.LightState);
            Assert.AreEqual(LightState.On, garageDoor.LightState);

            remoteControl.OffButtonWasPushed(0);
            Assert.AreEqual(LightState.Off, kitchenLight.LightState);
            Assert.AreEqual(LightState.Off, hallLight.LightState);
            Assert.AreEqual(LightState.Off, livingRoomLight.LightState);
            Assert.AreEqual(LightState.Off, garageDoor.LightState);

            remoteControl.UndoButtonWasPushed();
            Assert.AreEqual(LightState.On, kitchenLight.LightState);
            Assert.AreEqual(LightState.On, hallLight.LightState);
            Assert.AreEqual(LightState.On, livingRoomLight.LightState);
            Assert.AreEqual(LightState.On, garageDoor.LightState);
        }
    }
}
