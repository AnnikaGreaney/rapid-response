class GoogleMap
  def self.build_locations
    locations = ContactLocation.all
    hash = Gmaps4rails.build_markers(locations) do |location, marker|
      contact = Contact.find(location.contact_id)
      marker.lat location.latitude
      marker.lng location.longitude
      marker.title contact.first_name + " " + contact.last_name
      marker.infowindow ApplicationController.new.render_to_string(:partial => "dashboards/contact_locations/tooltip", :locals => {:location => location})
    end
    hash
  end
end
