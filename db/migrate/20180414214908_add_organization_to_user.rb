class AddOrganizationToUser < ActiveRecord::Migration
  def change
    add_column :users, :organization_id , :integer, :references => "organizations"
  end
end
