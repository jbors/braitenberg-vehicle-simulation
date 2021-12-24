namespace Objects.Vehicle {
	public class VehicleMovementExploration : VehicleMovement {
		public float[] MotorActivation(float[] sensorMeasurements) {
			// Do this slightly more complicated, in order to account for possible future vehicles with more than 1 set of motors
			// Inverted power combined with motor base speed then produces the characteristic behaviour

			var result = new float[sensorMeasurements.Length];

			// Per pair of two sensor inputs, switch them around
			for (var i = 1; i < result.Length; i += 2) {
				//TODO: how do the sensors influence the motors
			}
			
			return result;
		}
	}
}