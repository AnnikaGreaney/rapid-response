class CreateContact < ActiveRecord::Migration
  def change
    create_table :contacts do |t|
      t.string :first_name
      t.string :last_name
      t.string :email
      t.string :phone_number
      t.string :follow_me_id
      t.references :organization
      t.references :role
    end
  end
end
