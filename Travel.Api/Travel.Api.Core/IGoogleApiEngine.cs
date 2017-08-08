namespace Travel.Api.Core
{

    using System;
    using System.Collections.Generic;
    using Domain.Models;

    public interface IGoogleApiEngine
    {
        /// <summary>
        /// Distances the matrix.
        /// </summary>
        /// <param name="distanceMatrixRequest">The distance matrix request.</param>
        /// <returns>
        /// Returns distance matrix response.
        /// </returns>
        DistanceMatrixResponse DistanceMatrix(DistanceMatrixRequest distanceMatrixRequest);

        /// <summary>
        /// Gets the distance matrix request history.
        /// </summary>
        /// <returns>
        /// Returns the request history.
        /// </returns>
        List<RequestHistory> GetDistanceMatrixRequestHistory();

        /// <summary>
        /// Gets the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the request history.
        /// </returns>
        RequestHistory GetRequestHistory(Guid requestId);

        /// <summary>
        /// Replays the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the replayed request.
        /// </returns>
        DistanceMatrixResponse ReplayRequest(Guid requestId);

        /// <summary>
        /// Directionses the specified directions request.
        /// </summary>
        /// <param name="directionsRequest">The directions request.</param>
        /// <returns>
        /// Returns the directions.
        /// </returns>
        DirectionsResponse Directions(DirectionsRequest directionsRequest);

        /// <summary>
        /// Deletes the request history.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>
        /// Returns the response when request history is deleted.
        /// </returns>
        DeleteRequestHistoryResponse DeleteRequestHistory(Guid requestId);

        /// <summary>
        /// Elevations the specified elevation request.
        /// </summary>
        /// <param name="elevationRequest">The elevation request.</param>
        /// <returns>
        /// Returns the elevation data.
        /// </returns>
        ElevationResponse Elevation(ElevationRequest elevationRequest);

        /// <summary>
        /// Timezones the specified timezone request.
        /// </summary>
        /// <param name="timezoneRequest">The timezone request.</param>
        /// <returns>
        /// Returns the timezone.
        /// </returns>
        TimezoneResponse Timezone(TimezoneRequest timezoneRequest);
    }
}