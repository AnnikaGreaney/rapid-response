class CreatePersonOfInterest < ActiveRecord::Migration
  def change
    create_table :person_of_interests do |t|
      t.references :person
      t.text :information
    end
  end
end
