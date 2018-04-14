class CreatePersonDescription < ActiveRecord::Migration
  def change
    create_table :person_descriptions do |t|
      t.references :person
      t.string :hair_color
      t.string :hair_length
      t.string :eye_color
      t.string :hat
      t.string :top
      t.string :bottoms
      t.string :shoes
      t.string :bags
      t.text :additional_information
    end
  end
end
