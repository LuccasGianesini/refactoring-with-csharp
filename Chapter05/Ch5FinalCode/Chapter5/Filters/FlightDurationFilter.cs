﻿namespace Packt.CloudySkiesAir.Chapter5.Filters;

public class FlightDurationFilter : FlightFilterBase {
  public TimeSpan? MinDuration { get; set; }
  public TimeSpan? MaxDuration { get; set; }

  public override bool ShouldInclude(IFlightInfo flight) {
    if (MinDuration.HasValue && flight.Duration < MinDuration) {
      return false;
    }
    if (MaxDuration.HasValue && flight.Duration > MaxDuration) {
      return false;
    }
    return true;
  }
}
