class CreateIncidentImage < ActiveRecord::Migration
  def change
    create_table :incident_images do |t|
      t.string :image_title
      t.text :image_description
      t.string :image
    end
  end
end
