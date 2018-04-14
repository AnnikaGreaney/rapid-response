class CreateVehicle < ActiveRecord::Migration
  def change
    create_table :vehicles do |t|
      t.string :make
      t.string :model
      t.integer :year
      t.string :color
      t.string :license_plate
      t.string :license_plate_state
      t.text :comments
    end
  end
end
