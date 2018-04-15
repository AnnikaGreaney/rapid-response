module Dashboards
  class LocationsController < DashboardsController
      def index
        @locations = DashboardsController::ContactLocation.all
        @hash = GoogleMap.build_locations
    end
  end
end
