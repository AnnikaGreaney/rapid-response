class CreatePerson < ActiveRecord::Migration
  def change
    create_table :people do |t|
      t.string :first_name
      t.string :last_name
      t.date :date_of_birth
      t.string :gender
      t.string :height
      t.string :weight
      t.string :last_known_longitude
      t.string :last_known_latitude
      t.string :home_address
      t.string :home_city
      t.string :home_state
      t.string :home_zip
      t.references :person_designation
      t.references :person_description
      t.references :incident
    end
  end
end
