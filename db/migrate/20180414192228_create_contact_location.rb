class CreateContactLocation < ActiveRecord::Migration
  def change
    create_table :contact_locations do |t|
      t.references :contact
      t.string :longitude
      t.string :latitude
      t.references :task
    end
  end
end
