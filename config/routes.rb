RapidResponse::Application.routes.draw do
  ActiveAdmin.routes(self)
  devise_for :admin_users, :users
  draw_static_pages

  # REQUIRED
  # The Authenticated Root Path is used as the path the app redirects to after a sign in/up/settings change
  # It is generally the root of the app after a user has signed in
  get "/", to: "dashboards#overviews", as: :authenticated_root

  # Resources for user sign in/out/register/settings
  authenticate :user do
    namespace :dashboards do
      resources :overviews
      resources :contacts
      resources :people
      resources :vehicles
      resources :incidents
      resources :incident_images
      resources :person_descriptions
      resources :person_of_interests
      resources :organization_relations
      resources :locations
      resources :contact_locations
      resources :tasks
      resources :post_templates
    end
  end

  authenticate :admin_user do
    resources :organizations
  end

  draw :user_resources
end
