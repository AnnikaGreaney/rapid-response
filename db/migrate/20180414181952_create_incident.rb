class CreateIncident < ActiveRecord::Migration
  def change
    create_table :incidents do |t|
      t.string :incident_name
      t.references :subject, references: :person
      t.text :briefing
      t.text :persons_of_interest, array: true, default: []
      t.text :vehicles, array: true, default: []
      t.text :images, array: true, default: []
      t.text :additional_information
    end
  end
end
