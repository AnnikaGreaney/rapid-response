class CreateTask < ActiveRecord::Migration
  def change
    create_table :tasks do |t|
      t.string :title
      t.string :status
      t.text :details
      t.references :contact
      t.string :priority
    end
  end
end
