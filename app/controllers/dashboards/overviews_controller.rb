module Dashboards
  class OverviewsController < DashboardsController
    layout "dashboard"
    def index
      @hash = GoogleMap.build_locations
      user = current_user
      @available_users = Contact.where(organization_id: user.organization_id = 1)
    end
  end
end
